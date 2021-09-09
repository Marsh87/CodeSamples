using System;
using System.Threading;

namespace ReflectionCSharpExample.Models
{
    public class Car:IDrivable
    {
        public  string Colour { get; set; }
        public  string Make { get; set; }
        public  string Model { get; set; }
        public  double Price { get; set; }

        private int _speed;
        
        public double GetPriceIncludingVat()
        {
            var vat = 0.15;
            return (this.Price * vat) + this.Price;
        }

        public int GetYear()
        {
            return this.Model == "116i" ? 2008 : DateTime.Today.Year;
        }

        public void Start()
        {
            _speed += 1;
        }

        public void Stop()
        {
            _speed = 0;
        }

        public void IncreaseSpeed(int newSpeed)
        {
            _speed = newSpeed;
        }
    }
}