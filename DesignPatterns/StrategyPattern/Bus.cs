namespace StrategyPattern
{
    public class Bus:IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";  
        }
    }
}