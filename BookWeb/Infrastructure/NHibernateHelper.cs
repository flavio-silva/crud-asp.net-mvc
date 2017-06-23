using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;

namespace BookWeb.Infrastructure
{
    public class NHibernateHelper
    {
        private static ISessionFactory factory;

        static NHibernateHelper()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();

            factory = Fluently.Configure(cfg).
                Mappings(
                    x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                )
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return factory.OpenSession();
        }
    }
}