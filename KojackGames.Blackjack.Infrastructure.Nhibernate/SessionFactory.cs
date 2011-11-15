using NHibernate;
using NHibernate.Cfg;

namespace KojackGames.Blackjack.Infrastructure.Nhibernate
{
    public class SessionFactory
    {
        private static ISessionFactory _SessionFactory;

        public static void Init()
        {                       
            Configuration config = new Configuration();
            config.AddAssembly("KojackGames.Blackjack.Infrastructure.Nhibernate");
            
            config.Configure();

            _SessionFactory = config.BuildSessionFactory();
        }

        private static ISessionFactory GetSessionFactory()
        {
            if (_SessionFactory == null)
                Init();

            return _SessionFactory;
        }

        public static ISession GetNewSession()
        {
            return GetSessionFactory().OpenSession();
        }       
    }

}
