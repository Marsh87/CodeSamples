namespace StrategyPattern
{
    public interface IStrategy
    {
        string GetTravelTime(string source, string destination);
    }
}