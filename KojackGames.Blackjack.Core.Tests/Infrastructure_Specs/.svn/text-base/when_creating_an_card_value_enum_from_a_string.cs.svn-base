using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Infrastructure.Helpers;
using Machine.Specifications;
using NUnit.Framework;

namespace KojackGames.Blackjack.Core.Tests.Infrastructure_Specs
{
    [Subject(typeof(EnumParser))]
    public class when_creating_an_card_value_enum_from_a_string
    {
        private Because of = () => result = EnumParser.parse_enum<CardValue>("Two");

        private It should_convert_into_a_card_value_enum = () =>
        {
            Assert.That(result, Is.EqualTo(CardValue.Two));
        };

        private static CardValue result;
    }
}