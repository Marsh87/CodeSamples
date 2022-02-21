using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDesignPattern.Models;

namespace MVCDesignPattern.Interfaces
{
    public interface IVehicleView
    {
        void DisableAcceleration();
        void EnableAcceleration();
        void DisableDeceleration();
        void EnableDeceleration();
        void DisableTurning();
        void EnableTurning();
        void Update(AutoMobile paramModel);
    }
}
