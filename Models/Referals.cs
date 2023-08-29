﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    public partial class Referals
    {
        [Key]
        [Column("reference_id")]
        public int ReferenceId { get; set; }
        [Column("candidate_id")]
        public int? CandidateId { get; set; }
        [Column("reference_name")]
        [StringLength(100)]
        public string ReferenceName { get; set; }
        [Column("reference_email")]
        [StringLength(100)]
        public string ReferenceEmail { get; set; }
        [Column("reference_phone")]
        [StringLength(20)]
        public string ReferencePhone { get; set; }
        [Column("reference_relationship")]
        [StringLength(100)]
        public string ReferenceRelationship { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.Referals))]
        public virtual Candidates Candidate { get; set; }
    }
}
