using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class CustomerService
    {
        private readonly CustomerRepository customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer cus)
        {
            return customerRepository.AddCustomer(cus);
        }

        public List<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }
    }
}
