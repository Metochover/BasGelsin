using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Menu
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Price { get; set; }

        public string Contents { get; set; }

        public virtual ICollection<Product> Product { get; set; } = new List<Product>();

        public virtual ICollection<Promotion> Promotion { get; set; } = new List<Promotion>();
    }
}
