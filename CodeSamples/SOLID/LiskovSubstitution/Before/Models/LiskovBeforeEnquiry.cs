using CodeSamples.SOLID.LiskovSubstitution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.LiskovSubstitution.Before.Models
{

    public class LiskovBeforeEnquiry:LiskovBeforeCustomer
    {

        public override double Discount(double TotalSales)
        {
            return base.Discount(TotalSales) - 5;
        }

        // This override means that Enquriy cannot be substituted for other descendents on Customer
        public override void Add(Database database)
        {
            throw new Exception("Not allowed");
        }
    }
}
