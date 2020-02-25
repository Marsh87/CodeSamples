using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.SOLID.LiskovSubstitution.Before;
using CodeSamples.SOLID.LiskovSubstitution.Models;

namespace CodeSamples.SOLID.LiskovSubstitution.After
{
    public class LiskovAfter
    {
        public void ParseCustomers()
        {
            var database = new Database();
            var customers = new List<Customer>
            {
                new GoldCustomer(),
                new SilverCustomer(),
                /*new Enquiry() */// This will give a compiler error, rather than runtime error
            };

            foreach (Customer c in customers)
            {
                c.Add(database);
            }
        }
    }
}
