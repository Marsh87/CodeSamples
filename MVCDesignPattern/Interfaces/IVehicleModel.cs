using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDesignPattern.Enums;

namespace MVCDesignPattern.Interfaces
{
    public interface IVehicleModel
    {
        string Name { get; set; }
        int Speed { get; }
        int MaxSpeed { get; }
        int MaxTurnSpeed { get; }
        int MaxReverseSpeed { get; }
        DirectionEnums.AbsoluteDirection Direction { get; }
        void Turn(DirectionEnums.RelativeDirection paramDirection);
        void Accelerate(int paramAmount);
        void Decelerate(int paramAmount);
        void AddObserver(IVehicleView paramView);
        void RemoveObserver(IVehicleView paramView);
        void NotifyObservers();
    }
}
