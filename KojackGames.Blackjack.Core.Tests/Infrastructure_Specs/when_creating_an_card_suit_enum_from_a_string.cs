using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Infrastructure.Helpers;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Infrastructure_Specs
{
    [Subject(typeof(EnumParser))]
    public class when_creating_an_card_suit_enum_from_a_string
    {
        private Because of = () => result = EnumParser.parse_enum<Suit>("Clubs");

        private It should_convert_into_a_suit_value_enum = () =>
        {
            Assert.That(result, Is.EqualTo(Suit.Clubs));
        };

        private static Suit result;
    }
}
