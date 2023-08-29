using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("education")]
    public partial class Education
    {
        [Key]
        [Column("education_id")]
        public int EducationId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("degree")]
        [StringLength(100)]
        public string Degree { get; set; }
        [Required]
        [Column("institution")]
        [StringLength(100)]
        public string Institution { get; set; }
        [Column("field_of_study")]
        [StringLength(100)]
        public string FieldOfStudy { get; set; }
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Education))]
        public virtual Users User { get; set; }
    }
}
