using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class Projects
    {
        [Key]
        [Column("project_id")]
        public int ProjectId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("project_name")]
        [StringLength(100)]
        public string ProjectName { get; set; }
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.Projects))]
        public virtual Candidates Candidate { get; set; }
    }
}
