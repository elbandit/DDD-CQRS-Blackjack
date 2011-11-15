using System.IO;
using Cassini;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public class WebBrowser
    {        
        public const int Port = 14387;

        public static IE Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {
                    var ie = new IE("http://localhost:14387/");
                    ie.ClearCache();
                    ie.ClearCookies();
                    ScenarioContext.Current["browser"] = ie;
                }
                return (IE)ScenarioContext.Current["browser"];
            }
        }

        
        public static void Stop()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
                Current.Close();   
        }

        protected static Server WebServer { get; private set; }
       
        public static void InitializeBrowser()
        {
            WebServer = new Server(Port, "/", WebSiteFileLocation.get_physical_path());
            
            WebServer.Start();            
        }

        public static void ShutdownBrowser()
        {                        
            WebServer.Stop();
        }
    }
}
