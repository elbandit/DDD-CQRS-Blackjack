using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealCardsIn
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.DealCardsIn), "Dealer")]
    public class when_dealing_in_the_hands : with_a_deal_in_cards_action
    {        
        private Establish context = () =>
        {                        

        };
        
        Because of = () => SUT.perform_on(positions, card_shoe, player);

        It should_take_take_four_cards_from_the_card_shoe =
            () => card_shoe.AssertWasCalled(x => x.take_card(), o => o.Repeat.Times(4));

        It should_give_two_cards_to_the_player =
            () => players_hand.AssertWasCalled(x => x.add(Arg<Card>.Is.Anything), o => o.Repeat.Times(2));

        It should_give_two_cards_to_the_dealer =
            () => dealers_hand.AssertWasCalled(x => x.add(Arg<Card>.Is.Anything), o => o.Repeat.Times(2));

        It should_update_the_hand_status_with_the_handStatusFactory =
            () => hand_status_factory.AssertWasCalled(x => x.set_status_for(hand));
        
        It should_check_if_hand_achieves_blackjack =
            () => positions.AssertWasCalled(x => x.player_has_blackjack());
        
        private static HandStatus hand_status;        
    }
}
