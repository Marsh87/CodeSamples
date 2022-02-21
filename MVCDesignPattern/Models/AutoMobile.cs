using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDesignPattern.Enums;
using MVCDesignPattern.Interfaces;

namespace MVCDesignPattern.Models
{
    public  abstract class AutoMobile: IVehicleModel
    {
       
        private ArrayList aList = new ArrayList();
        private int mintSpeed = 0;
        private int mintMaxSpeed = 0;
        private int mintMaxTurnSpeed = 0;
        private int mintMaxReverseSpeed = 0;
        private DirectionEnums.AbsoluteDirection mDirection = DirectionEnums.AbsoluteDirection.North;
        private string mstrName = "";

        public AutoMobile(int paramMaxSpeed, int paramMaxTurnSpeed, int paramMaxReverseSpeed, string paramName)
        {
            this.mintMaxSpeed = paramMaxSpeed;
            this.mintMaxTurnSpeed = paramMaxTurnSpeed;
            this.mintMaxReverseSpeed = paramMaxReverseSpeed;
            this.mstrName = paramName;
        }
      
        public void AddObserver(IVehicleView paramView)
        {
            aList.Add(paramView);
        }
        public void RemoveObserver(IVehicleView paramView)
        {
            aList.Remove(paramView);
        }
        public void NotifyObservers()
        {
            foreach (IVehicleView view in aList)
            {
                view.Update(this);
            }
        }
        public string Name
        {
            get
            {
                return this.mstrName;
            }
            set
            {
                this.mstrName = value;
            }
        }
        public int Speed
        {
            get
            {
                return this.mintSpeed;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return this.mintMaxSpeed;
            }
        }
        public int MaxTurnSpeed
        {
            get
            {
                return this.mintMaxTurnSpeed;
            }
        }
        public int MaxReverseSpeed
        {
            get
            {
                return this.mintMaxReverseSpeed;
            }
        }
        public DirectionEnums.AbsoluteDirection Direction
        {
            get
            {
                return this.mDirection;
            }
        }
        public void Turn(DirectionEnums.RelativeDirection paramDirection)
        {
            DirectionEnums.AbsoluteDirection newDirection;
            switch (paramDirection)
            {
                case DirectionEnums.RelativeDirection.Right:
                    newDirection = (DirectionEnums.AbsoluteDirection)((int)(this.mDirection + 1) % 4);
                    break;
                case DirectionEnums.RelativeDirection.Left:
                    newDirection = (DirectionEnums.AbsoluteDirection)((int)(this.mDirection + 3) % 4);
                    break;
                case DirectionEnums.RelativeDirection.Back:
                    newDirection = (DirectionEnums.AbsoluteDirection)((int)(this.mDirection + 2) % 4);
                    break;
                default:
                    newDirection = DirectionEnums.AbsoluteDirection.North;
                    break;
            }
            this.mDirection = newDirection;
            this.NotifyObservers();
        }
        public void Accelerate(int paramAmount)
        {
            this.mintSpeed += paramAmount;
            if (mintSpeed >= this.mintMaxSpeed) mintSpeed = mintMaxSpeed;
            this.NotifyObservers();
        }
        public void Decelerate(int paramAmount)
        {
            this.mintSpeed -= paramAmount;
            if (mintSpeed <= this.mintMaxReverseSpeed) mintSpeed = mintMaxReverseSpeed;
            this.NotifyObservers();
        }
    }
}
