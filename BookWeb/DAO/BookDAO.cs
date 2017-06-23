using BookWeb.Infrastructure;
using BookWeb.Models;
using NHibernate;
using System.Collections.Generic;

namespace BookWeb.DAO
{
    public class BookDAO
    {   

        public Book Find(int id)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Book>(id);
            }
        }

        public IList<Book> All()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IQuery query = session.CreateQuery("SELECT b FROM Book b");
                return query.List<Book>();
            }
        }

        public void Create(Book book)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(book);
                tx.Commit();
            }            
        }

        public void Update(Book book)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(book);
                tx.Commit();
            }
        }

        public void Delete(int id)
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                var book = Find(id);
                ITransaction tx = session.BeginTransaction();
                session.Delete(book);
                tx.Commit();
            }
        }
    }
}