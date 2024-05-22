using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.PromotionProduct
{
    public class PromotionProductDTO :BaseDTO
    {
        public double? Price { get; set; }
        public int? PromationId { get; set; }
    }
}
