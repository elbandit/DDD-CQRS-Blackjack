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
    public class GameDisplaySteps
    {
        [Then(@"I should be told to ""(.*)""")]
        public void ThenIShouldBeToldTo(string message)
        {
            Assert.That(BetOnHandPage.flash_message, Is.EqualTo(message));
        }

        [Then(@"I should be given the option for insurance")]
        public void ThenIShouldBeGivenTheOptionForInsurance()
        {
            Assert.That(GameDisplayPage.has_insurance_button, Is.True);
        }

        [Then(@"I should not be given the option for insurance")]
        public void ThenIShouldNotBeGivenTheOptionForInsurance()
        {
            Assert.That(GameDisplayPage.does_not_have_insurance_button, Is.True);
        }

        [Then(@"my pot should show ""(.*)"" dollars")]
        public void ThenMyPotShouldShow(string dollars_in_pot)
        {
            Assert.That(GameDisplayPage.pot_amount, Is.EqualTo(dollars_in_pot));
        }

        [Then(@"I should be asked ""(.*)""")]
        public void ThenIShouldBeAskedToCashIn(string message)
        {
            Assert.That(GameDisplayPage.game_status_message, Is.EqualTo(message));
        }

        [Then(@"I should be offered to double my stake")]
        public void ThenIShouldBeOfferedToDoubleMyStake()
        {
            Assert.That(GameDisplayPage.has_double_button, Is.True);
        }

        [Then(@"I should be offered to split my hand")]
        public void ThenIShouldBeOfferedToSplitMyHand()
        {
            Assert.That(GameDisplayPage.has_split_button, Is.True);
        }
        
   
        [Then(@"the dealers hand should show the following cards:")]
        public void ThenTheDealersHandShouldShowTheFollowingCards(Table table)
        {
            var dealers_cards = GameDisplayPage.dealers_cards();

            foreach (var card in table.Rows)
            {
                Assert.That(dealers_cards.Contains(card["card"]), Is.True);
            }    
        }
        

        [Then(@"my hand should show the following cards:")]
        public void ThenMyHandShouldShowTheFollowingCards(Table table)
        {
            var players_cards = GameDisplayPage.players_cards_for_hand("A");

            foreach(var card in table.Rows)
            {
                Assert.That(players_cards.Contains(card["card"]), Is.True);
            }            
        }

        [Then(@"hand ""(.*)"" should show the following cards:")]
        public void ThenTheHandShouldShowTheFollowingCards(string hand_letter, Table table)
        {
            var players_cards = GameDisplayPage.players_cards_for_hand(hand_letter);

            foreach (var card in table.Rows)
            {
                Assert.That(players_cards.Contains(card["card"]), Is.True);
            }
        }

        [Then(@"I should be dealt two cards")]
        public void ThenIShouldBeDealtTwoCards()
        {
            var players_cards = GameDisplayPage.players_cards_for_hand("A");

            Assert.That(players_cards.Count(), Is.EqualTo(2));
        }

        [Then(@"the dealer should be dealt two cards")]
        public void ThenTheDealerShouldBeDealtTwoCards()
        {
            var dealers_cards = GameDisplayPage.dealers_cards();

            Assert.That(dealers_cards.Count(), Is.EqualTo(2));
        }

        [Then(@"I should see the deal button")]
        public void ThenIShouldSeeTheDealButton()
        {
            Assert.That(BetOnHandPage.has_deal_button, Is.True);
        }

        [Then(@"I should given the option to hit")]
        public void ThenIShouldGivenTheOptionToHit()
        {
            Assert.That(BetOnHandPage.has_hit_button, Is.True);
        }

        [Then(@"I should given the option to stick")]
        public void ThenIShouldGivenTheOptionToStick()
        {
            Assert.That(BetOnHandPage.has_stick_button, Is.True);
        }
        
        [Then(@"the player should win the game")]
        public void ThenThePlayerShouldWinTheGame()
        {
            Assert.That(GameDisplayPage.player_status_message, Is.EqualTo("Won"));
        }

        [Then(@"the player should lose the game")]
        public void ThenThePlayerShouldLoseTheGame()
        {
            Assert.That(GameDisplayPage.player_status_message, Is.EqualTo("Lost"));
        }

        [Then(@"players hand ""(.*)"" should have won")]
        public void PlayersHandShouldWin(string hand_letter)
        {
            Assert.That(GameDisplayPage.player_status_message_for(hand_letter), Is.EqualTo("Won"));
        }
       
        [Then(@"the game should be drawn")]
        public void ThenTheGameShouldBeDrawn()
        {
            Assert.That(GameDisplayPage.player_status_message, Is.EqualTo("Push"));            
        }

         [Then(@"I should see the bet button")]
        public void ThenIShouldSeeTheBetButton()
        {
            Assert.That(BetOnHandPage.has_bet_button, Is.True);
        }	
    }
}
