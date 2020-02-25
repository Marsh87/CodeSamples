using System.Collections.Generic;
using CodeSamples.SOLID.DependencyInjection.Models;

namespace CodeSamples.SOLID.DependencyInjection.Before
{
    public class OrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            return new List<Order>();
        }
    }
}