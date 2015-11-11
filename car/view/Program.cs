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
          
           // Console.OutputEncoding = Encoding.UTF8;
            var carLada = new Car("2107", "D");
            carLada.Color = Color.Indigo; // вроде этот цвет похож на баклажановый
            if (carLada.carPassport.Owner != null)
                Console.WriteLine(" Владелец машины {0}",carLada.carPassport.Owner.Name);
            else
            {
                Console.WriteLine("У машины еще нет владельца");
            }

            Console.WriteLine("----------------------------------------");

            var driver = new Driver(new DateTime(1800, 01, 01, 6, 0,0), "Вольдемар") {Category = "BC"};

            try
            {
                carLada.ChangeOwner(driver, "o777oo");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------------------");

            driver.Category = driver.Category + "D";

            try
            {
                carLada.ChangeOwner(driver, "T777AZ");
                Console.WriteLine("водитель успешно сменен");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("номер машины {1}а: {0}",driver.Car.CarNumber, driver.Name);

            Console.WriteLine("----------------------------------------");

            if (carLada.carPassport.Owner != null)
                Console.WriteLine("владелец машины {0} - {1}",carLada.Model, carLada.carPassport.Owner.Name);

            Console.ReadKey();
            

        }
    }
}
