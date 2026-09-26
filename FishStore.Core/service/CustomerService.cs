using FishStore.Core.repository;
using FishStore.model;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class CustomerService
    {
        private readonly CustomerRepository customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer cus)
        {
            return customerRepository.AddCustomer(cus);
        }

        public List<Customer> GetAll(string name = null)
        {
            return customerRepository.GetAll(name);
        }
    }
}
