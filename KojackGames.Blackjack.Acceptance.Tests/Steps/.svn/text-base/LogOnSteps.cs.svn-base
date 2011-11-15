using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class LogOnSteps
    {
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            LoginPage.login();
        }

        [Then(@"I should be redirected to login")]
        public void ThenIShouldBeRedirectedToLoginOrCreateAnAccount()
        {
            Assert.That(LoginPage.title, Is.EqualTo("Login"));
        }

        [Given(@"that I have logged in with an account with the following details")]
        public void GivenThatIHaveAnAccountWithTheFollowingDetails(Table table)
        {
            SiteNavigator.go_to_registration_page();
            RegistrationPage.set_email_to = table.Rows[0]["Email"];
            RegistrationPage.set_password_to = table.Rows[0]["Password"];
            RegistrationPage.set_name_to = table.Rows[0]["Name"]; 
            RegistrationPage.register();

            // find the user id
            PlayerToken.player_id = DataBaseHelper.get_user_id_from_membership_table_by(table.Rows[0]["Email"]);
            
        }      
    }
}
