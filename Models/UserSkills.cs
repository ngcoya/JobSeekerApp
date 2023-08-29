using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("user_skills")]
    public partial class UserSkills
    {
        [Key]
        [Column("user_skill_id")]
        public int UserSkillId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("skill_id")]
        public int SkillId { get; set; }

        [ForeignKey(nameof(SkillId))]
        [InverseProperty(nameof(Skills.UserSkills))]
        public virtual Skills Skill { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.UserSkills))]
        public virtual Users User { get; set; }
    }
}
