using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class Certifications
    {
        [Key]
        [Column("certification_id")]
        public int CertificationId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("certification_name")]
        [StringLength(100)]
        public string CertificationName { get; set; }
        [Column("issuing_organization")]
        [StringLength(100)]
        public string IssuingOrganization { get; set; }
        [Column("issue_date", TypeName = "date")]
        public DateTime? IssueDate { get; set; }
        [Column("expiration_date", TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.Certifications))]
        public virtual Candidates Candidate { get; set; }
    }
}
