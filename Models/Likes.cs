using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("likes")]
    public partial class Likes
    {
        [Key]
        [Column("like_id")]
        public int LikeId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("post_id")]
        public int PostId { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Likes))]
        public virtual Users User { get; set; }
    }
}
