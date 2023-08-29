using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            Achievements = new HashSet<Achievements>();
            CandidateAcademics = new HashSet<CandidateAcademics>();
            CandidateExperience = new HashSet<CandidateExperience>();
            CandidateSkills = new HashSet<CandidateSkills>();
            Certifications = new HashSet<Certifications>();
            Languages = new HashSet<Languages>();
            Projects = new HashSet<Projects>();
            Referals = new HashSet<Referals>();
        }

        [Key]
        [Column("candidate_id")]
        public int CandidateId { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("address")]
        [StringLength(100)]
        public string Address { get; set; }
        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("country")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column("postal_code")]
        [StringLength(20)]
        public string PostalCode { get; set; }
        [Column("rsa_identity_num")]
        [StringLength(14)]
        public string RsaIdentityNum { get; set; }
        [Column("profile_picture_url")]
        [StringLength(200)]
        public string ProfilePictureUrl { get; set; }

        [InverseProperty("Candidate")]
        public virtual ICollection<Achievements> Achievements { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<CandidateAcademics> CandidateAcademics { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<CandidateExperience> CandidateExperience { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<CandidateSkills> CandidateSkills { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<Certifications> Certifications { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<Languages> Languages { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<Projects> Projects { get; set; }
        [InverseProperty("Candidate")]
        public virtual ICollection<Referals> Referals { get; set; }
    }
}
