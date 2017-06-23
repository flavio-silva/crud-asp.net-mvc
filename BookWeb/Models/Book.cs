using System;

namespace BookWeb.Models
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Isbn { get; set; }
        public virtual double Price { get; set; }
        public virtual int Pages { get; set; }
        public virtual string Authors { get; set; }
        public virtual string Formats { get; set; }
        public virtual string Categories { get; set; }
        public virtual DateTime PublishedAt { get; set; }
    }
}