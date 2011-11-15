using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Events
{
    [Binding]
    public class FeatureEvents
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            
        }

        [BeforeScenario]
        public void BeforeScenario()
        {         
            WebBrowser.InitializeBrowser();
            SiteNavigator.sign_out();
            DataBaseHelper.clear_db();
        }

        [AfterScenario]
        public void AfterScenario()
        {            
            WebBrowser.Current.Close();
            WebBrowser.ShutdownBrowser();
        }
    }    
}
