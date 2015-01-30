using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simorgh.Models
{
    public class UserMessage
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FromUserName { get; set; }

        [Required]
        public string ToUserName { get; set; }

        public int? ReplyToMessage { get; set; }

        [Required]
        public string MessageText { get; set; }

        [Required]
        public DateTime MessageTime { get; set; }

        public Boolean isRead { get; set; }

    }

    public class MessageDbContext : DbContext
    {
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}