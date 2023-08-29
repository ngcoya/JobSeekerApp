using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("endorsements")]
    public partial class Endorsements
    {
        [Key]
        [Column("endorsement_id")]
        public int EndorsementId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("skill_id")]
        public int SkillId { get; set; }
        [Column("endorsed_by")]
        public int EndorsedBy { get; set; }
        [Column("endorsement_date")]
        public DateTime? EndorsementDate { get; set; }

        [ForeignKey(nameof(SkillId))]
        [InverseProperty(nameof(Skills.Endorsements))]
        public virtual Skills Skill { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Endorsements))]
        public virtual Users User { get; set; }
    }
}
