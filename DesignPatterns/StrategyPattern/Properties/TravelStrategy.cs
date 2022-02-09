using System;

namespace StrategyPattern.Properties
{
    public class TravelStrategy
    {
        private IStrategy _strategy;  
        public TravelStrategy(IStrategy chosenStrategy) {  
            _strategy = chosenStrategy;  
        }  
        public void GetTravelTime(string source, string destination) {  
            var result = _strategy.GetTravelTime(source, destination);  
            Console.WriteLine(result);  
        }  
    }
}