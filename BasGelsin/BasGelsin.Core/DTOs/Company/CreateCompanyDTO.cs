using BasGelsin.Core.DTOs.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Company
{
    public class CreateCompanyDTO 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string Photo { get; set; }
        public int? TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public int? MersisNumber { get; set; }
        public virtual CreateAddressDTO address { get; set; }

    }
}
