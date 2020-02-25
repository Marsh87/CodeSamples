using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.SOLID.LiskovSubstitution.Models;

namespace CodeSamples.SOLID.DependencyInjection.After
{
    public class CustomerRepository:ICustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
