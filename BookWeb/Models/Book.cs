using System;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Book
    {
        public virtual int Id { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string Title { get; set; }
        
        [StringLength(255)]
        public virtual string Subtitle { get; set; }
        [Required]
        [StringLength(17)]
        public virtual string Isbn { get; set; }
        [Required]        
        public virtual double Price { get; set; }
        [Required]        
        public virtual int Pages { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Authors { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Formats { get; set; }
        [Required]
        [StringLength(10)]
        public virtual string Categories { get; set; }
        [Required]        
        public virtual DateTime? PublishedAt { get; set; }
    }
}