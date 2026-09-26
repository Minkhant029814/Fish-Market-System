using FishStore.Core.dto.creditPay;
using FishStore.database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishStore.Core.repository.creditPay
{
    public class CreditPaymentRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public bool PayCredit(CreditPayment payment)
        {
            MySqlConnection conn = null;
            MySqlTransaction transaction = null;

            try
            {
                conn = dbConn.GetConnection();
                conn.Open();
                transaction = conn.BeginTransaction();

                // ============================================
                // ၁။ Credit ရဲ့ လက်ရှိအခြေအနေ စစ်ဆေးပါ
                // ============================================
                string checkQuery = @"
                SELECT creditId, totalAmount, paidAmount, remainingAmount, status 
                FROM credits 
                WHERE creditId = @CreditId";

                decimal totalAmount = 0;
                decimal paidAmount = 0;
                decimal remainingAmount = 0;

                using (MySqlCommand cmd = new MySqlCommand(checkQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@CreditId", payment.CreditId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalAmount = reader.GetDecimal("totalAmount");
                            paidAmount = reader.GetDecimal("paidAmount");
                            remainingAmount = reader.GetDecimal("remainingAmount");
                        }
                        else
                        {
                            throw new Exception("အကြွေးမှတ်တမ်း မတွေ့ပါ။");
                        }
                    }
                }

                // ============================================
                // ၂။ ဆပ်ငွေ စစ်ဆေးပါ
                // ============================================
                if (payment.PayAmount > remainingAmount)
                {
                    throw new Exception($"ဆပ်ငွေက ကျန်ငွေထက် ကျော်နေပါတယ်။ ကျန်ငွေ: {remainingAmount:N2}");
                }

                // ============================================
                // ၃။ CreditPayments ထဲထည့်ပါ
                // ============================================
                string insertPaymentQuery = @"
                INSERT INTO credit_payments 
                    (creditId, amount, paymentDate, paymentMethod, note)
                VALUES 
                    (@CreditId, @Amount, @PaymentDate, @Method, @Note)";

                using (MySqlCommand cmd = new MySqlCommand(insertPaymentQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@CreditId", payment.CreditId);
                    cmd.Parameters.AddWithValue("@Amount", payment.PayAmount);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@Method", payment.PaymentMethod ?? "ငွေသား");
                    cmd.Parameters.AddWithValue("@Note", payment.Note ?? "");
                    cmd.ExecuteNonQuery();
                }

                // ============================================
                // ၄။ Credits ဇယားကို Update လုပ်ပါ
                // ============================================
                decimal newPaidAmount = paidAmount + payment.PayAmount;
                string newStatus;

                if (newPaidAmount >= totalAmount)
                    newStatus = "paid";
                else if (newPaidAmount > 0)
                    newStatus = "partial";
                else
                    newStatus = "unpaid";

                string updateCreditQuery = @"
                UPDATE credits 
                SET paidAmount = @Paid, status = @Status 
                WHERE creditId = @CreditId";

                using (MySqlCommand cmd = new MySqlCommand(updateCreditQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@Paid", newPaidAmount);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@CreditId", payment.CreditId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine($"Error in PayCredit: {ex.Message}");
                throw;
            }
            finally
            {
                conn?.Close();
            }
        }
    }
}
