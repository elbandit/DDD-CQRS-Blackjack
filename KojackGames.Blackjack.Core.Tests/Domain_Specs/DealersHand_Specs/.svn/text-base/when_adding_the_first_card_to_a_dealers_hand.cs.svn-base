using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealersHand_Specs
{
    [Subject(typeof(DealersHand), "Dealers hand")]
    public class when_adding_the_first_card_to_a_dealers_hand
    {
        private Establish context = () =>
        {
            card = new Card(Suit.Spades, CardValue.Four);
            SUT = new DealersHand(black_jack_table);
        };

        private Because of = () => SUT.add(card);

        private It should_show_the_cards_value = () =>
        {
            Assert.That(card.name, Is.EqualTo("Four of Spades"));
        };

        private static IBlackJackTable black_jack_table;
        private static DealersHand SUT;
        private static Card card;
    }
}
