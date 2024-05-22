using BasGelsin.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Category
{
    public class CategoryDTO : BaseDTO
    {
        public int? SubId { get; set; }
        public int? CompanyId { get; set; }
        public virtual ICollection<Product.ProductDTO> Product { get; set; }
        public virtual List<CategoryDTO> Subcategories { get; set; }

    }
}
