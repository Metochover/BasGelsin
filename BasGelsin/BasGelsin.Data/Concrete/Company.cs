using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.Data.Concrete
{
    public partial class Company
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Photo { get; set; }

        public int? TaxNumber { get; set; }

        public string TaxOffice { get; set; }

        public int? MersisNumber { get; set; }

        public string RegistrationDate { get; set; }

        public string PasswordResetToken { get; set; }

        public DateTime? PasswordResetExpiresAt { get; set; }

        public string EmailProofToken { get; set; }

        public DateTime? EmailProofTokenExpiresAt { get; set; }

        public string SignToken { get; set; }

        public bool? IsLogin { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<Address> Address { get; set; } = new List<Address>();

        public virtual ICollection<Category> Category { get; set; } = new List<Category>();
    }
}
