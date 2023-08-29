using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class CandidateSkills
    {
        [Key]
        [Column("skill_id")]
        public int SkillId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("skill_name")]
        [StringLength(100)]
        public string SkillName { get; set; }
        [Column("proficiency_level")]
        [StringLength(50)]
        public string ProficiencyLevel { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.CandidateSkills))]
        public virtual Candidates Candidate { get; set; }
    }
}
