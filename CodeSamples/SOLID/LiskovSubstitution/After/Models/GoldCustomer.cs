namespace CodeSamples.SOLID.LiskovSubstitution.Models
{

    public class GoldCustomer : Customer
    {
        // Research difference between new and override
        /*The difference between override and new is that override extend 
        the method of base class with new definition 
        but new hides the method of base class.*/
        public override double Discount(double sales)
        {
            return sales - 40;
        }
    }
}