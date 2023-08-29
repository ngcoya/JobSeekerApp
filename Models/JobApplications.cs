using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("job_applications")]
    public partial class JobApplications
    {
        [Key]
        [Column("application_id")]
        public int ApplicationId { get; set; }
        [Column("job_id")]
        public int JobId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("application_date")]
        public DateTime? ApplicationDate { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey(nameof(JobId))]
        [InverseProperty(nameof(Jobs.JobApplications))]
        public virtual Jobs Job { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.JobApplications))]
        public virtual Users User { get; set; }
    }
}
