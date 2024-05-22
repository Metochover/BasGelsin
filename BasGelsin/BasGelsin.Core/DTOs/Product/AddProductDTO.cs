using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Product
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public int? CategoryId { get; set; }
    }
}
