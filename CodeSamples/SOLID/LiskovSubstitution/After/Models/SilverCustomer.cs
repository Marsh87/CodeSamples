namespace CodeSamples.SOLID.LiskovSubstitution.Models
{

    public class SilverCustomer : Customer
    {
        public override double Discount(double sales)
        {
            return sales - 20;
        }
    }
}