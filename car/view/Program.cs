using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace view
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1;
            car1 = new Car("2107", "B");
            
            Console.WriteLine(car1.carPassport.Car.Model);
            Console.ReadKey();
            //var carpassport = new CarPasport(car1);

        }
    }
}
