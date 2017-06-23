using BookWeb.Models;
using FluentNHibernate.Mapping;

namespace BookWeb.Mappings
{
    public class BookMapping : ClassMap<Book>
    {
        public BookMapping()
        {
            Id(post => post.Id).GeneratedBy.Identity();
            Map(post => post.Title);
            Map(post => post.Subtitle);
            Map(post => post.Isbn);
            Map(post => post.Price);
            Map(post => post.Pages);
            Map(post => post.Authors);            
            Map(post => post.Formats);
            Map(post => post.Categories);
            Map(post => post.PublishedAt).Column("published_at");
            Table("books");
        }
    }
}