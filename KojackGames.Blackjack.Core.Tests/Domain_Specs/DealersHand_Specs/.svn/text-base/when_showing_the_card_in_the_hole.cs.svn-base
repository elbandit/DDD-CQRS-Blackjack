using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealersHand_Specs
{
    [Subject(typeof(DealersHand), "Dealers hand")]
    public class when_showing_the_card_in_the_hole
    {
        private Establish context = () =>
                                        {
                                            first_card = new Card(Suit.Spades, CardValue.Four);
                                            second_card = new Card(Suit.Diamonds, CardValue.Jack);
                                            SUT = new DealersHand(black_jack_table);

                                            SUT.add(first_card);
                                            SUT.add(second_card);
                                        };

        private Because of = () => SUT.show_card_in_hole();

        private It should_show_the_cards_value = () =>
                                                     {
                                                         Assert.That(second_card.name, Is.EqualTo("Jack of Diamonds"));
                                                     };

        private static IBlackJackTable black_jack_table;
        private static DealersHand SUT;
        private static Card first_card;
        private static Card second_card;
    }
}