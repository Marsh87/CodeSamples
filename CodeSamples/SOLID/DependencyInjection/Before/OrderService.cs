using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.SOLID.DependencyInjection.Models;

namespace CodeSamples.SOLID.DependencyInjection.Before
{
    public class OrderService
    {
        private  readonly  OrderRepository _orderRepository = new OrderRepository();
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders().ToList();
        }
    }
}
