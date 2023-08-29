using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("comments")]
    public partial class Comments
    {
        [Key]
        [Column("comment_id")]
        public int CommentId { get; set; }
        [Column("post_id")]
        public int PostId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("content", TypeName = "text")]
        public string Content { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(Posts.Comments))]
        public virtual Posts Post { get; set; }
    }
}
