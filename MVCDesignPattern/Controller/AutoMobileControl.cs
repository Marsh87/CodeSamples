using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDesignPattern.Enums;
using MVCDesignPattern.Interfaces;

namespace MVCDesignPattern.Controller
{
    public class AutoMobileControl : IVehicleControl
    {
        private IVehicleModel Model;
        private IVehicleView View;

        public AutoMobileControl(IVehicleModel paramModel, IVehicleView paramView)
        {
            this.Model = paramModel;
            this.View = paramView;
        }

        public AutoMobileControl()
        {
        }

        #region IVehicleControl Members

        public void SetModel(IVehicleModel paramModel)
        {
            this.Model = paramModel;
        }

        public void SetView(IVehicleView paramView)
        {
            this.View = paramView;
        }

        public void RequestAccelerate(int paramAmount)
        {
            if (Model != null)
            {
                Model.Accelerate(paramAmount);
                if (View != null) SetView();
            }
        }

        public void RequestDecelerate(int paramAmount)
        {
            if (Model != null)
            {
                Model.Decelerate(paramAmount);
                if (View != null) SetView();
            }
        }

        public void RequestTurn(DirectionEnums.RelativeDirection paramDirection)
        {
            if (Model != null)
            {
                Model.Turn(paramDirection);
                if (View != null) SetView();
            }
        }

        #endregion

        public void SetView()
        {
            if (Model.Speed >= Model.MaxSpeed)
            {
                View.DisableAcceleration();
                View.EnableDeceleration();
            }
            else if (Model.Speed <= Model.MaxReverseSpeed)
            {
                View.DisableDeceleration();
                View.EnableAcceleration();
            }
            else
            {
                View.EnableAcceleration();
                View.EnableDeceleration();
            }

            if (Model.Speed >= Model.MaxTurnSpeed)
            {
                View.DisableTurning();
            }
            else
            {
                View.EnableTurning();
            }
        }
    }
}
