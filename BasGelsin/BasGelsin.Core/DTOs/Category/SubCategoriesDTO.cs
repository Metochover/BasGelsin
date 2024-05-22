using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Category
{
    public class SubCategoriesDTO :BaseDTO
    {
        public int? SubId { get; set; }
        public int? CompanyId { get; set; }
        public virtual ICollection<Product.ProductDTO> Product { get; set; }
    }
}
