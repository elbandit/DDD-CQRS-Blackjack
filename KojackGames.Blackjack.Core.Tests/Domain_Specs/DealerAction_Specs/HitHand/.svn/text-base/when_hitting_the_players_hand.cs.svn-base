using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Model;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.HitHand
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.HitHand), "Hit")]
    public class when_hitting_the_players_hand : with_a_hit_hand_action
    {
        private Establish context = () =>
        {
            player = MockRepository.GenerateStub<IPlayer>();
            card_shoe = MockRepository.GenerateStub<ICardShoe>();
            playing_positions = MockRepository.GenerateStub<IPlayingPositions>();
            players_hand = MockRepository.GenerateStub<IPlayersHand>();
            players_hand.Stub(x => x.turn_ended()).Return(false);
            playing_positions.Stub(x => x.players_active_hand).Return(players_hand);            
        };

        Because of = () => SUT.action_to_perform(playing_positions, card_shoe, player);

        private It should_take_a_card_from_the_card_shoe = () =>
        {
            card_shoe.AssertWasCalled(x => x.take_card());
        };

        private It should_add_a_card_to_the_players_hand = () =>
        {
            players_hand.AssertWasCalled(x => x.add(Arg<Card>.Is.Anything));
        };
                
        private static IPlayingPositions playing_positions;
        private static ICardShoe card_shoe;
        private static IPlayersHand players_hand;
        private static IPlayer player;
    }
}
