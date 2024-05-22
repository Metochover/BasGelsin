using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Address
{
    public class CreateAddressDTO
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string FullAddress { get; set; }
    }
}
