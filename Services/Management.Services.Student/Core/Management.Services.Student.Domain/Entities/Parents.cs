using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Domain.Entities
{
    public class Parents : BaseEntity
    {
        public string FatherFirstName { get; set; } = string.Empty;
        public string FatherMiddleName { get; set; } = string.Empty;
        public string FatherLastName { get; set; } = string.Empty;
        public DateTime FDOB { get; set; }
        public int FatherAge { get; set; }
        public string MotherFirstName { get; set; } = string.Empty;
        public string MotherMiddleName { get; set; } = string.Empty;
        public string MotherLastName { get; set; } = string.Empty;
        public DateTime MDOB { get; set; }
        public string FatherAdharNumber { get; set; } = string.Empty;
        public string MotherAdharNumber { get; set; } = string.Empty;
        public string SepeicalCaste { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Village { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostOffice { get; set; } = string.Empty;
        public string Distict { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
    }
}
