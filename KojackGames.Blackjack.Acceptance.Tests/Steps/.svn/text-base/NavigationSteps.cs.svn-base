using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{    
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            SiteNavigator.go_to_login(); 
        }

        [When(@"I navigate to the account page")]
        public void WhenINavigateToTheAccountPage()
        {
            SiteNavigator.go_to_account_home();   
        }

        [Given(@"that I have not logged In")]
        public void GivenThatIHaveNotLoggedIn()
        {
            
        }
       
        [Given(@"I have navigated to the game play screen to play a hand")]
        public void GivenIAmOnTheGamePlayScreen()
        {                        
            SiteNavigator.go_to_bet_page();            
        }

        [Given(@"I have navigated to the game play screen")]
        public void GivenIHaveNavigatedToTheGamePlayScreen()
        {
            SiteNavigator.go_to_bet_page();   
        }

        [When(@"I navigate to the game play screen")]
        public void WhenINavigateToTheGamePlayScreen()
        {
            SiteNavigator.go_to_bet_page();   
        }

        [Given(@"I have navigated to the registration page")]
        public void GivenIHaveNavigatedToTheRegistrationPage()
        {
            SiteNavigator.go_to_registration_page();
        }
    }
}
