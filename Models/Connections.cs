using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Models
{
    [Table("connections")]
    public partial class Connections
    {
        [Key]
        [Column("connection_id")]
        public int ConnectionId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("connected_user_id")]
        public int ConnectedUserId { get; set; }
        [Required]
        [Column("status")]
        [StringLength(20)]
        public string Status { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Connections))]
        public virtual Users User { get; set; }
    }
}
