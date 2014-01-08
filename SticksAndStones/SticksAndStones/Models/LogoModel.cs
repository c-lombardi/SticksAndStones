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
    public class Logo
    {
        [Key]
        Guid ID { get; set; }
        string Name { get; set; }
        string Subname { get; set; }
        string LogoURL { get; set; }
    }
    
    public class LogoModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "subname")]
        public string Subname { get; set; }
    }
}