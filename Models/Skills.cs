using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("skills")]
    public partial class Skills
    {
        public Skills()
        {
            Endorsements = new HashSet<Endorsements>();
            UserSkills = new HashSet<UserSkills>();
        }

        [Key]
        [Column("skill_id")]
        public int SkillId { get; set; }
        [Required]
        [Column("skill_name")]
        [StringLength(100)]
        public string SkillName { get; set; }

        [InverseProperty("Skill")]
        public virtual ICollection<Endorsements> Endorsements { get; set; }
        [InverseProperty("Skill")]
        public virtual ICollection<UserSkills> UserSkills { get; set; }
    }
}
