using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? SubId { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<Product> Product { get; set; } = new List<Product>();
    }
}
