using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("recommendations")]
    public partial class Recommendations
    {
        [Key]
        [Column("recommendation_id")]
        public int RecommendationId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("recommender_id")]
        public int RecommenderId { get; set; }
        [Column("content", TypeName = "text")]
        public string Content { get; set; }
        [Column("given_at")]
        public DateTime? GivenAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Recommendations))]
        public virtual Users User { get; set; }
    }
}
