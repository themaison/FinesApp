using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp
{
    class Driver
    {
        private String _licenseNumber;
        public String LicenseNumber {
            get { return _licenseNumber; }  
            set { _licenseNumber = value; }
        }

        public Driver(String license_number)
        {
            this._licenseNumber = license_number;
        }

    }
}
