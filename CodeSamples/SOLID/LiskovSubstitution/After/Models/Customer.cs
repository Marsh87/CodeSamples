using System;
using CodeSamples.SOLID.LiskovSubstitution.After;
using CodeSamples.SOLID.LiskovSubstitution.Before;

namespace CodeSamples.SOLID.LiskovSubstitution.Models
{
    public class Customer:IDiscount,IDatabase
    {
        public virtual double Discount(double sales)
        {
            return sales;
        }

        public void Add(Database db)
        {
            db.Add();
        }
    }
}