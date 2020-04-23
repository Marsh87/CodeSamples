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

        public override void Add(Database database)
        {
            throw new Exception("Not allowed");
        }
    }
}
