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
            var customers = new List<Customer>
            {
                new GoldCustomer(),
                new SilverCustomer(),
                /*new Enquiry() */// This will give a compiler error, rather than runtime error
            };
            SaveCustomers(customers);
        }

        private static void SaveCustomers(List<Customer> customers)
        {
            var database = new Database();
            foreach (Customer c in customers)
            {
                c.Add(database);
            }
        }
    }
}
