using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class Achievements
    {
        [Key]
        [Column("achievement_id")]
        public int AchievementId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.Achievements))]
        public virtual Candidates Candidate { get; set; }
    }
}
