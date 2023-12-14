using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp
{
    public class Driver
    {

        public string LicenseNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LicenseIssueDate { get; set; }
        public DateTime LicenseValidity { get; set; }

        public Driver(string licenseNumber, string fullName, string gender, DateTime birthDate, DateTime licenseIssueDate, DateTime licenseValidity)
        {
            LicenseNumber = licenseNumber;
            FullName = fullName;
            Gender = gender;
            BirthDate = birthDate;
            LicenseIssueDate = licenseIssueDate;
            LicenseValidity = licenseValidity;
        }
    }
}
