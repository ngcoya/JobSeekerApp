using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class CandidateAcademics
    {
        [Key]
        [Column("education_id")]
        public int EducationId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("degree")]
        [StringLength(100)]
        public string Degree { get; set; }
        [Column("major")]
        [StringLength(100)]
        public string Major { get; set; }
        [Column("school_name")]
        [StringLength(100)]
        public string SchoolName { get; set; }
        [Column("completion_date", TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.CandidateAcademics))]
        public virtual Candidates Candidate { get; set; }
    }
}
