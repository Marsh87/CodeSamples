﻿namespace StrategyPattern
{
    public class Bike:IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 25 minutes to reach from " + source + " to " + destination + " using Bike.";
        }
    }
}