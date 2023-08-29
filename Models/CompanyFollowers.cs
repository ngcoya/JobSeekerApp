using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("company_followers")]
    public partial class CompanyFollowers
    {
        [Key]
        [Column("follower_id")]
        public int FollowerId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Column("follow_date")]
        public DateTime? FollowDate { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.CompanyFollowers))]
        public virtual Companies Company { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.CompanyFollowers))]
        public virtual Users User { get; set; }
    }
}
