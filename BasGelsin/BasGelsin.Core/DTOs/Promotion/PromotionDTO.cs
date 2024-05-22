using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Promotion
{
    public class PromotionDTO :BaseDTO
    {
        public int? MenuId { get; set; }

        public virtual ICollection<PromotionProduct.PromotionProductDTO> PromotionProduct { get; set; }
    }
}
