using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private IOrderRepository _orderRepository;
        public CustomerRepository(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Customer FindBy(Guid id)
        {
            Customer customer = new CustomerProxy();
            // Code to connect to the database and retrieve a customer…Patterns in Data access
            ((CustomerProxy)customer).OrderRepository = _orderRepository;

            return customer;

        }
    }
}
