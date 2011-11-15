using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class AccountSetUpSteps
    {
        [Given(@"that I have an account with the following details")]
        public void GivenThatIHaveAnAccountWithTheFollowingDetails(Table table)
        {
            SiteNavigator.go_to_registration_page();
            RegistrationPage.set_email_to = table.Rows[0]["Email"];
            RegistrationPage.set_password_to = table.Rows[0]["Password"];
            RegistrationPage.set_name_to = table.Rows[0]["Name"]; 
            RegistrationPage.register();
            SiteNavigator.sign_out();
        }

        [Given(@"I have ""(.*)"" dollars in my pot")]
        public void GivenIHaveDollarsInMyPot(decimal dollars_in_pot)
        {
            var player = new PlayersBuilder().find_player_with_id_of(PlayerToken.player_id)
                                              .set_pot_to(dollars_in_pot)
                                              .build();

            DataBaseHelper.save_or_add(player);
        }
    }
}
