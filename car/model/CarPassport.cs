using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class CarPassport
    {
        public Car Car { get; }

        public CarPassport(Car car)
        {
            Car = car;
        }

        public Driver Owner { get; set; } 

    }
}
