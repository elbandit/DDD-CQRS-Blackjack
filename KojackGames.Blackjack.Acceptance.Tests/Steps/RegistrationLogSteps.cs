using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class RegistrationLogSteps
    {
        [Then(@"I should find ""(.*)"" ""(.*)"" entries in the logs")]
        public void ThenIShouldFindTheFollowingEntriesInTheLogs(int number_of_entries, string type_of_entry)
        {
            var logs = DataBaseHelper.find_all<MembershipEventsRow>();

            Assert.That(logs.Count(), Is.EqualTo(number_of_entries));
        }

        [When(@"I check the regisration logs")]
        public void WhenICheckTheRegisrationLogs()
        {
            // do nothing..
        }
    }
}
