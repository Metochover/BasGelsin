using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Core.DTOs.Category
{
    public class AddCategoryDTO 
    {
        public string Name { get; set; }

        public int? SubId { get; set; }

        public int? CompanyId { get; set; }
    }
}
