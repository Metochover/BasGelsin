using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Menu
{
    public class MenuDTO :BaseDTO
    {
        public int? Price { get; set; }
        public string Contents { get; set; }
        public virtual ICollection<Product.ProductDTO> Product { get; set; }
        public virtual ICollection<Promotion.PromotionDTO> Promotion { get; set; }
    }
}
