namespace DecoratorPattern
{
    public class DeluxeCar:ICar
    {
        public string GetDescription()
        {
            return "Deluxe Car";
        }

        public double GetCost()
        {
            return 750000.0; 
        }
    }
}