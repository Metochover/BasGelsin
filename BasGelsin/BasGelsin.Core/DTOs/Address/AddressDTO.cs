using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Address
{
    public class AddressDTO :BaseDTO
    {
        public string City { get; set; }
        public string Town { get; set; }
        public string FullAddress { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
    }
}
