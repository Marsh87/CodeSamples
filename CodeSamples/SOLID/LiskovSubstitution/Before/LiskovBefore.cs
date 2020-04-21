using CodeSamples.SOLID.LiskovSubstitution.Models;
using System.Collections.Generic;

namespace CodeSamples.SOLID.LiskovSubstitution.Before
{
    public partial class LiskovBefore
    {
        public class CustomerParser
        {
            void ParseCustomer()
            {
                var database= new Database();
                var customers = new List<Customer>()
                {
                    new GoldCustomer(),
                    new SilverCustomer(),
                    //new Enquiry() Enquiry use to inhertit from Customer in the Before Example
                };

                foreach (Customer c in customers)
                {
                    c.Add(database);
                }
            }
        }
    }
}
