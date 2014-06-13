using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDP
{
    public abstract class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
    }
}
