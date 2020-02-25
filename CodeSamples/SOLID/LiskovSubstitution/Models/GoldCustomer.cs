namespace CodeSamples.SOLID.LiskovSubstitution.Models
{

    public class GoldCustomer : Customer
    {
        public new int Discount(int sales)
        {
            return sales - 40;
        }
    }
}