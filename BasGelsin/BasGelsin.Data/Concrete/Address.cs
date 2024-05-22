using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Address
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Town { get; set; }

        public string FullAddress { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int? CompanyId { get; set; }

        public int? UserId { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }
    }

}
