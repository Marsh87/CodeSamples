using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern.Models
{
    public class SportsCar:AutoMobile
    {
        public SportsCar(string paramName) : base(250, 40, -20, paramName) { }
        public SportsCar(int paramMaxSpeed, int paramMaxTurnSpeed, int paramMaxReverseSpeed, string paramName) : base(paramMaxSpeed, paramMaxTurnSpeed, paramMaxReverseSpeed, paramName)
        {
        }
    }
}
