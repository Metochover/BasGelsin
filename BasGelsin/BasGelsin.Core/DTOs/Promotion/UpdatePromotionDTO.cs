using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Promotion
{
    public class UpdatePromotionDTO:BaseDTO
    {
        public int? MenuId { get; set; }
        public virtual ICollection<int>? PromotionProduct { get; set; }
    }
}
