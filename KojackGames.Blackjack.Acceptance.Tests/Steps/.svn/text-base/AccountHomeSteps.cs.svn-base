using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class AccountHomeSteps
    {
        [Then(@"a message should say hello ""(.*)""")]
        public void ThenAMessageShouldSayHello(string user_name)
        {
            Assert.That(AccountHomePage.welcome_note, Is.EqualTo(string.Format("Hello {0}", user_name)));
        }

        [Then(@"I should be logged in to my account section")]
        public void ThenIShouldBeLoggedInToMyAccountSection()
        {
            
        }
    }
}
