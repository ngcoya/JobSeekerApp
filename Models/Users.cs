using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("users")]
    public partial class Users
    {
        public Users()
        {
            CompanyFollowers = new HashSet<CompanyFollowers>();
            Connections = new HashSet<Connections>();
            Education = new HashSet<Education>();
            Endorsements = new HashSet<Endorsements>();
            Experiences = new HashSet<Experiences>();
            JobApplications = new HashSet<JobApplications>();
            Likes = new HashSet<Likes>();
            Messages = new HashSet<Messages>();
            Posts = new HashSet<Posts>();
            Recommendations = new HashSet<Recommendations>();
            UserSkills = new HashSet<UserSkills>();
        }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("date_of_birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        [Column("profile_picture")]
        [StringLength(50)]
        public string ProfilePicture { get; set; }
        [Column("headline")]
        [StringLength(200)]
        public string Headline { get; set; }
        [Column("summary", TypeName = "text")]
        public string Summary { get; set; }
        [Column("location")]
        [StringLength(100)]
        public string Location { get; set; }
        [Column("ISACTIVE")]
        public int Isactive { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(11)]
        public string CellNumber { get; set; }
        [StringLength(11)]
        public string AltCellNumber { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<CompanyFollowers> CompanyFollowers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Connections> Connections { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Education> Education { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Endorsements> Endorsements { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Experiences> Experiences { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<JobApplications> JobApplications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Likes> Likes { get; set; }
        [InverseProperty("Sender")]
        public virtual ICollection<Messages> Messages { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Posts> Posts { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Recommendations> Recommendations { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserSkills> UserSkills { get; set; }
    }
}
