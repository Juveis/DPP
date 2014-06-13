using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDP
{
    public class JapanFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new Toyota();
        }

        public override MotorCycle CreateMotorCycle()
        {
            return new Suzuki();
        }
    }
}
