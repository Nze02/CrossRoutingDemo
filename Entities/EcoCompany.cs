using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrossRouting.Models
{
    public class EcoCompany
    {
        [Key]
        [Display(Name = "Company ID")]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyOID { get; set; } = -1;

        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(250)]
        public string Street { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        public string Country { get; set; }

        [Required]
        public string Email { get; set; }
  
    }
}
