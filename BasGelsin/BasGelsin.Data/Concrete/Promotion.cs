using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Promotion
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual ICollection<PromotionProduct> PromotionProduct { get; set; } = new List<PromotionProduct>();
    }
}
