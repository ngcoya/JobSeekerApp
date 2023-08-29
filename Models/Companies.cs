using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("companies")]
    public partial class Companies
    {
        public Companies()
        {
            CompanyFollowers = new HashSet<CompanyFollowers>();
            Jobs = new HashSet<Jobs>();
        }

        [Key]
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Required]
        [Column("company_name")]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Column("industry")]
        [StringLength(100)]
        public string Industry { get; set; }
        [Column("website")]
        [StringLength(200)]
        public string Website { get; set; }
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("founded_date", TypeName = "date")]
        public DateTime? FoundedDate { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [InverseProperty("Company")]
        public virtual ICollection<CompanyFollowers> CompanyFollowers { get; set; }
        [InverseProperty("Company")]
        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
