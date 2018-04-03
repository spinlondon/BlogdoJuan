using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogdoJuan.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        public DateTime DataAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        [Required]
        [AllowHtml]
        [StringLength(3000)]
        public string PostingBody { get; set; }
    }
}