using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDP
{
    public class ItalyFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new Ferrari();
        }

        public override MotorCycle CreateMotorCycle()
        {
            return new Ducati();
        }
    }
}
