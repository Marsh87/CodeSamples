using CodeSamples.SOLID.LiskovSubstitution.After;

namespace CodeSamples.SOLID.LiskovSubstitution.Models
{
    public class Enquiry : IDiscount
    {
        public double Discount(double sales)
        {
            return sales  - 100;
        }
    }
}