using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealCardsIn
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.DealCardsIn))]
    public class when_a_players_hand_meets_the_criteria_to_split_after_dealing : with_a_deal_in_cards_action
    {
        private Establish context = () =>
        {
            split_spec.Stub(x => x.is_satisfied_by(players_hand)).Return(true);
        };

        Because of = () => SUT.perform_on(positions, card_shoe, player);

        It should_check_the_players_hand_for_a_pair = () =>
        {
            split_spec.AssertWasCalled(x => x.is_satisfied_by(players_hand));
        };

        It should_mark_the_players_hand_as_being_able_to_split_his_hand = () =>
        {
            players_hand.AssertWasCalled(x => x.mark_as_able_to_split());
        };    
    }
}
