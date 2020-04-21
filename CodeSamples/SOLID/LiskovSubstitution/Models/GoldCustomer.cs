namespace CodeSamples.SOLID.LiskovSubstitution.Models
{

    public class GoldCustomer : Customer
    {
        // Research differenc between new and override
        public new int Discount(int sales)
        {
            return sales - 40;
        }
    }
}