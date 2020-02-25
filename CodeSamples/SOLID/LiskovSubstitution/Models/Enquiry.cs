using CodeSamples.SOLID.LiskovSubstitution.After;

namespace CodeSamples.SOLID.LiskovSubstitution.Models
{
    public class Enquiry : IDiscount
    {
        public new int Discount(int sales)
        {
            return sales  - 100;
        }
    }
}