using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Models.Responses
{
    public class StudentResponse
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string LastUpdatedBy { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string AdharNumber { get; set; } = string.Empty;
        public string FatherAdharNumber { get; set; } = string.Empty;
        public string MotherAdharNumnber { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public bool IsSpecialCategory { get; set; } = false;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Village { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostOffice { get; set; } = string.Empty;
        public string Distict { get; set; } = string.Empty;
        public string PinCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactNumber1 { get; set; } = string.Empty;
        public string ContactNumber2 { get; set; } = string.Empty;
        public string WhatsAppNumber { get; set; } = string.Empty;
    }
}
