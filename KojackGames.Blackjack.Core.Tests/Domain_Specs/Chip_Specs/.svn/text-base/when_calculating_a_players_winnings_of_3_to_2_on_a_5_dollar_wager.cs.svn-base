using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.Chip_Specs
{
    [Subject(typeof(Chips))]
    public class when_calculating_a_players_winnings_of_3_to_2_on_a_5_dollar_wager
    {
        private Establish context = () =>
        {
            SUT = new Chips(5m);
        };

        private Because of = () => result = SUT.mulitple_by_odds_of(3, 2);
                        
        private It should_create_chips_with_a_value_of_7_dollars_and_50_cents = () =>
        {
            Assert.That(result.value, Is.EqualTo(7.50m));
        };
       
        private static Chips SUT;
        private static Chips result;
    }
}
