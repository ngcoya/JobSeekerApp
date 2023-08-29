using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("experiences")]
    public partial class Experiences
    {
        [Key]
        [Column("experience_id")]
        public int ExperienceId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Column("company")]
        [StringLength(100)]
        public string Company { get; set; }
        [Column("location")]
        [StringLength(100)]
        public string Location { get; set; }
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Experiences))]
        public virtual Users User { get; set; }
    }
}
