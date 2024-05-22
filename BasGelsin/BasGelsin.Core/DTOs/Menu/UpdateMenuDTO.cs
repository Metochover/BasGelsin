using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Menu
{
    public class UpdateMenuDTO:BaseDTO
    {
        public int? Price { get; set; }
        public string? Contents { get; set; }
        public virtual ICollection<int>? Product { get; set; }
        public virtual ICollection<int>? Promotion { get; set; }
    }
}
