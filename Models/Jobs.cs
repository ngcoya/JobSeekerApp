using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("jobs")]
    public partial class Jobs
    {
        public Jobs()
        {
            JobApplications = new HashSet<JobApplications>();
        }

        [Key]
        [Column("job_id")]
        public int JobId { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column("location")]
        [StringLength(100)]
        public string Location { get; set; }
        [Column("job_type")]
        [StringLength(50)]
        public string JobType { get; set; }
        [Column("salary", TypeName = "decimal(10, 2)")]
        public decimal? Salary { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
        [Column("posted_at")]
        public DateTime? PostedAt { get; set; }
        [Column("is_active")]
        public int IsActive { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.Jobs))]
        public virtual Companies Company { get; set; }
        [InverseProperty("Job")]
        public virtual ICollection<JobApplications> JobApplications { get; set; }
    }
}
