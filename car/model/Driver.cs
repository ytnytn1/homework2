using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
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

        public int Expirience
        {
            get
            {
                var span = DateTime.Now - LicenseDate;
                var expirience = (int)span.TotalDays/365;
                return expirience;
            }
        }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }

            else
            {
                throw new MyException(string.Format("{0} не обладает категорией {1} ", Name, car.Category));
            }
        }
            
    }
}
