using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Car
    {
        //CarPasport carPasport;
        public CarPassport carPassport { get; }

        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            carPassport = new CarPassport(this);
        }

        public string Model { get; }

        public string Category { get; }

        public Color Color { get; set; } = Color.Blue;

        //public  string Model { get; set; }

        public  int CarNumber { get; private set; }



    }
}
