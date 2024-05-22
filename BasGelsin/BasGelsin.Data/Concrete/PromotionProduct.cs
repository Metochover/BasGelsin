using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class PromotionProduct
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double? Price { get; set; }

        public int? PromationId { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Promotion Promation { get; set; }
    }
}
