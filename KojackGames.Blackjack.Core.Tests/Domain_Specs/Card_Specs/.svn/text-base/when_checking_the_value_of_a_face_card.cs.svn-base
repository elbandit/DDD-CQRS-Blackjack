using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.Card_Specs
{
    [Subject(typeof(Card), "card")]
    public class when_checking_the_value_of_a_face_card
    {
        private Establish context = () =>
        {
            SUT = new Card(Suit.Spades, CardValue.King);
        };

        private Because of = () => result = SUT.score;

        private It should_use_the_spec_to_make_sure_it_can_take_a_card = () =>
        {
            Assert.That(result, Is.EqualTo(10));
        };

        private static Card SUT;
        private static int result;
    }
}
