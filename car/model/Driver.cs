using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Driver
    {
       

       

        public Driver(DateTime licenseDate, string name)
        {
            LicenseDate = licenseDate;
            Name = name;
        }

        public string Name { get; }

        public DateTime LicenseDate { get; }

        public string Category { get; set; }

        public int Expirience => DateTime.Now.Year - LicenseDate.Year;

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
                Car = car;
            else throw new MyException(Name + " не обладает категорией " + car.Category);
        }
            
    }
}
