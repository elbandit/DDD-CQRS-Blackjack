using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Infrastructure.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class CardDeckSteps
    {
        public Deck current_deck
        {
            get { return (Deck)ScenarioContext.Current["current_deck"]; }
            set { ScenarioContext.Current["current_deck"] = value; }
        }

        public List<Card> cards_taken
        {
            get
            {
                if(!ScenarioContext .Current.ContainsKey("cards_taken"))
                    ScenarioContext.Current["cards_taken"] = new List<Card>();

                return (List<Card>)ScenarioContext.Current["cards_taken"];
            }
            set { ScenarioContext.Current["cards_taken"] = value; }
        }

        [Given(@"I have taken the first card")]
        public void GivenIHaveTakenTheFirstCard()
        {            
            cards_taken.Add(current_deck.take_card());
        }

        [Given(@"I have shuffled the deck")]
        public void GivenIHaveShuffledTheDeck()
        {
            current_deck.shuffle();
        }

        [Given(@"that the card is a ""(.*)"" of ""(.*)""")]
        public void GivenThatTheCardIs(string value, string suit)
        {
            var card_suit = EnumParser.parse_enum<Suit>(suit);
            var card_value = EnumParser.parse_enum<CardValue>(value);

            var card = cards_taken[0];

            Assert.That(card.card_value, Is.EqualTo(card_value));
            Assert.That(card.suit, Is.EqualTo(card_suit));
        }

        [Then(@"the last ""(.*)"" cards taken should not be equal to:")]
        public void ThenTheLastCardsTakenShouldNotBeEqualTo(int number_of_cards, Table table)
        {
            var last_n_cards = cards_taken.Skip(cards_taken.Count() - number_of_cards).ToList();

            bool card_sequence_does_not_match = true;

            var card_index = 0;
            foreach( var row in table.Rows)
            {
                var card_suit = EnumParser.parse_enum<Suit>(row["Suit"]);
                var card_value = EnumParser.parse_enum<CardValue>(row["Value"]);

                if (last_n_cards[card_index].card_value == card_value &&
                    last_n_cards[card_index].suit == card_suit)
                    card_sequence_does_not_match = false;
    
                card_index ++;
            }

            Assert.That(card_sequence_does_not_match, Is.True);
        }

        [Then(@"the last ""(.*)"" cards taken should be equal to:")]
        public void ThenTheLastCardsTakenShouldBeEqualTo(int number_of_cards, Table table)
        {
            var last_n_cards = cards_taken.Skip(cards_taken.Count() - number_of_cards).ToList();

            var card_index = 0;
            foreach (var row in table.Rows)
            {
                var card_suit = EnumParser.parse_enum<Suit>(row["Suit"]);
                var card_value = EnumParser.parse_enum<CardValue>(row["Value"]);

                Assert.That(last_n_cards[card_index].card_value, Is.EqualTo(card_value));
                Assert.That(last_n_cards[card_index].suit, Is.EqualTo(card_suit));

                card_index++;
            }
        }

        [Then(@"I should have 51 cards left in the deck")]
        public void ThenIShouldHave51CardsLeftInTheDeck()
        {
            Assert.That(current_deck.no_of_cards_left_in_deck, Is.EqualTo(51));
        }
                              
        [Given(@"I have a new deck of 52 cards")]
        public void GivenIHaveANewDeckOf52Cards()
        {
            var deck = new Deck();
            deck.initialize();

            current_deck = deck;
        }
        
        [When(@"I take ""(.*)"" cards")]
        public void WhenITakeCards(int number_of_cards_to_take)
        {            
            var deck = current_deck;

            int no_of_cards_left_to_take = number_of_cards_to_take;

            while(no_of_cards_left_to_take > 0)
            {
                cards_taken.Add(deck.take_card());
                no_of_cards_left_to_take --;
            }            
        }

        [Then(@"I should have 52 unique cards")]
        public void ThenIShouldHave52UniqueCards()
        {
            var cards = cards_taken;

            Assert.That(cards.Count(), Is.EqualTo(52));

            foreach(var card in cards)
            {
                Assert.That(cards.Count(x => x.Equals(card)), Is.EqualTo(1));
            }
        }

        [Then(@"an empty deck")]
        public void ThenAnEmptyDeck()
        {
            Assert.That(current_deck.no_of_cards_left_in_deck, Is.EqualTo(0));
        }
    }
}
