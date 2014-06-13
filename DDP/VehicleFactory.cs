using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDP
{
    public abstract class VehicleFactory
    {
        public abstract Car CreateCar();
        public abstract MotorCycle CreateMotorCycle();
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
