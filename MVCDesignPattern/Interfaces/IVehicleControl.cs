using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDesignPattern.Enums;

namespace MVCDesignPattern.Interfaces
{
    public interface IVehicleControl
    {
        void RequestAccelerate(int paramAmount);
        void RequestDecelerate(int paramAmount);
        void RequestTurn(DirectionEnums.RelativeDirection paramDirection);
        void SetModel(IVehicleModel paramAuto);
        void SetView(IVehicleView paramView);
    }
}
