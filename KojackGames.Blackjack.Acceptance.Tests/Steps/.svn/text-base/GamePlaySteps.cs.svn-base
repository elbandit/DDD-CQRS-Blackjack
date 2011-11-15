
using System.Diagnostics;
using System.Linq;
using KojackGames.Blackjack.Acceptance.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class GamePlaySteps
    {

        [When(@"I click on take insurance")]
        public void WhenIClickOnTakeInsurance()
        {
            GameDisplayPage.take_insurance();
        }

        [When(@"I click on the double button")]
        public void WhenIClickOnTheDoubleButton()
        {
            GameDisplayPage.double_down();
        }

        [When(@"I click on the split button")]
        public void WhenIClickOnTheSplitButton()
        {
            GameDisplayPage.split();
        }

        [When(@"I click on the deal button")]
        public void WhenIClickOnTheDealButton()
        {
            BetOnHandPage.deal();
        }

        [When(@"I hit")]
        public void WhenIHit()
        {
            GameDisplayPage.hit();
        }

        [When(@"I stick")]
        public void WhenIStick()
        {            
            GameDisplayPage.stick();
        }

        [When(@"I click the start new game button")]
        public void WhenIClickNewGame()
        {
            GameDisplayPage.click_new_game_button();
        }

        [When(@"I click on the bet button")]
        public void WhenIClickOnTheBetButton()
        {
            BetOnHandPage.bet_5_dollars();
        }

        [Given(@"I click on the bet button")]
        public void GivenIClickOnTheBetButton()
        {
            BetOnHandPage.bet_5_dollars();
        }
    }
}
