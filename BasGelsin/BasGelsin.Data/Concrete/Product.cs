using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public int? MenuId { get; set; }

        public int? Price { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual ICollection<PromotionProduct> PromotionProduct { get; set; } = new List<PromotionProduct>();
    }
}
