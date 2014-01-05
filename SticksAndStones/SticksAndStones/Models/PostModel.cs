using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SticksAndStones.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class PostModel
    {
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required]
        [Display(Name = "Body")]
        public string Body { get; set; }
    }
}