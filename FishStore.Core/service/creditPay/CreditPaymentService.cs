using FishStore.Core.dto.creditPay;
using FishStore.Core.repository.creditPay;
using System;

namespace FishStore.Core.service.creditPay
{
    public class CreditPaymentService
    {
        private readonly CreditPaymentRepository repo = new CreditPaymentRepository();

        public bool PayCredit(CreditPayment payment)
        {
            if (payment == null)
                throw new ArgumentNullException("Payment မရှိပါ။");

            if (payment.PayAmount <= 0)
                throw new ArgumentException("ဆပ်ငွေသည် ၀ ထက် ကြီးရပါမည်။");

            return repo.PayCredit(payment);
        }
    }
}
