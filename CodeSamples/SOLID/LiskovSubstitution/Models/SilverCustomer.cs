namespace CodeSamples.SOLID.LiskovSubstitution.Models
{

    public class SilverCustomer : Customer
    {
        public new int Discount(int sales)
        {
            return sales - 20;
        }
    }
}