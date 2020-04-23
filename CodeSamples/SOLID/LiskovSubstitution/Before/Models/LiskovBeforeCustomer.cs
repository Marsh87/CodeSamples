using CodeSamples.SOLID.LiskovSubstitution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.LiskovSubstitution.Before.Models
{
    public class LiskovBeforeCustomer 
    {
        public virtual double Discount(double sales)
        {
            return sales;
        }

        public virtual void Add(Database db)
        {
            db.Add();
        }
    }
}
