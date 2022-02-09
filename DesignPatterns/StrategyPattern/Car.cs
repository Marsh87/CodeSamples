namespace StrategyPattern
{
    public class Car:IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 40 minutes to reach from " + source + " to " + destination + " using Car."; 
        }
    }
}