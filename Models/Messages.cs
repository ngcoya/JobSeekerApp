using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("messages")]
    public partial class Messages
    {
        [Key]
        [Column("message_id")]
        public int MessageId { get; set; }
        [Column("sender_id")]
        public int SenderId { get; set; }
        [Column("receiver_id")]
        public int ReceiverId { get; set; }
        [Required]
        [Column("content", TypeName = "text")]
        public string Content { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [ForeignKey(nameof(SenderId))]
        [InverseProperty(nameof(Users.Messages))]
        public virtual Users Sender { get; set; }
    }
}
