using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Product
{
    public class ProductDTO : BaseDTO
    {
        public int? Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
