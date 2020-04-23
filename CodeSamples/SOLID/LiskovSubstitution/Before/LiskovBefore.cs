using CodeSamples.SOLID.LiskovSubstitution.Before.Models;
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
                var customers = new List<LiskovBeforeCustomer>()
                {
                    new LiskovBeforeGoldCustomer(),
                    new LiskovBeforeSilverCustomer(),
                    new LiskovBeforeEnquiry()
                };

                foreach (LiskovBeforeCustomer c in customers)
                {
                    c.Add(database);
                }
            }
        }
    }
}
