using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class RegisterPlayerSteps
    {
        [Given(@"I have registered these people:")]
        public void GivenIHaveRegisteredThesePeople(Table table)
        {            
            foreach(var row in table.Rows)
            {
                SiteNavigator.go_to_registration_page();
                RegistrationPage.set_email_to = row["Email"];
                RegistrationPage.set_password_to = row["Password"];
                RegistrationPage.set_name_to = row["Name"];
                RegistrationPage.register();
                SiteNavigator.sign_out();
            }            
        }

        [Given(@"I have entered ""(.*)"" for my email")]
        public void GivenIHaveEnteredAnEmail(string email)
        {
            RegistrationPage.set_email_to = email;
        }

        [Given(@"I have entered ""(.*)"" for my password")]
        public void GivenIHaveEnteredAPassword(string password)
        {
            RegistrationPage.set_password_to = password;
        }

        [When(@"I press register")]
        public void WhenIPressRegister()
        {
            RegistrationPage.register();
        }

        [Given(@"I have entered ""(.*)"" for my name")]
        public void GivenIHaveEnteredMyName(string name)
        {
            RegistrationPage.set_name_to = name;
        }       
    }
}