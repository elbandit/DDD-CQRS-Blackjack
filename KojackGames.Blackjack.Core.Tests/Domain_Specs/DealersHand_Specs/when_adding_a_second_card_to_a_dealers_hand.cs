using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealersHand_Specs
{
    [Subject(typeof(DealersHand), "Dealers hand")]
    public class when_adding_a_second_card_to_a_dealers_hand
    {
        private Establish context = () =>
        {
            var first_card = new Card(Suit.Spades, CardValue.Four);
            second_card = new Card(Suit.Clubs, CardValue.Jack);
            SUT = new DealersHand(black_jack_table);

            SUT.add(first_card);
        };

        private Because of = () => SUT.add(second_card);

        private It should_hide_the_cards_value = () =>
        {
                Assert.That(second_card.name, Is.EqualTo("hidden"));
        };

        private static IBlackJackTable black_jack_table;
        private static DealersHand SUT;        
        private static Card second_card;
    }
}