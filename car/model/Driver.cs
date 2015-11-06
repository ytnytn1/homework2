using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Driver
    {
        private DateTime _licenseDate;

        private string _name;

        public Driver(DateTime licenseDate, string name)
        {
            _licenseDate = licenseDate;
            _name = name;
        }

        public string Category { get; set; }


    }
}
