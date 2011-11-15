using System;
using System.IO;
using NHibernate;
using NHibernate.Cfg;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public class SessionFactory
    {
        private static ISessionFactory _SessionFactory;

        public static void Init()
        {
            set_app_data_directory();

            Configuration config = new Configuration();
                      
            config.Configure(String.Format(@"{0}\web.config", WebSiteFileLocation.get_physical_path()));
            config.AddAssembly("KojackGames.Blackjack.Acceptance.Tests");            

            _SessionFactory = config.BuildSessionFactory();
        }

        private static void set_app_data_directory()
        {
            string path = string.Format(@"{0}\App_data\", WebSiteFileLocation.get_physical_path());
            var absoluteDataDirectory = Path.GetFullPath(path); 
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);
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
