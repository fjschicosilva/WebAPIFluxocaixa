using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using WebAPIFluxocaixa.Models;
using ISession = NHibernate.ISession;

namespace WebAPIFluxocaixa.Repository
{

    public class SessionFactory
    {
        private static string connectionString = "Server=SL097; Database=webapifluxocaixa; User Id=sa; Password=Sms130170; Trusted_Connection=True; TrustServerCertificate=True;";
        private static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
                return session;

            IPersistenceConfigurer configDB =
              MsSqlConfiguration.MsSql2012
                .ConnectionString(connectionString);
            var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Lancamentos>());
            session = configMap.BuildSessionFactory();
            return session;
        }
        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
