using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.StickHand
{
    [Subject(typeof(Domain.GamePlay.Model.Dealer.Actions.StickHand), "Stick Hand Action")]
    public class when_sticking_a_hand : with_a_stick_action
    {
        private Establish context = () =>
        {
            player = MockRepository.GenerateStub<IPlayer>();
            card_shoe = MockRepository.GenerateStub<ICardShoe>();
            playing_positions = MockRepository.GenerateStub<IPlayingPositions>();
            players_hand = MockRepository.GenerateStub<IPlayersHand>();
            playing_positions.Stub(x => x.players_active_hand).Return(players_hand);
        };

        Because of = () => SUT.perform_on(playing_positions, card_shoe, player);
        
        It should_change_the_players_hand_status_to_stick =
            () => players_hand.AssertWasCalled(x => x.change_state_to(HandStatus.stick));

        private static IPlayingPositions playing_positions;
        private static ICardShoe card_shoe;
        private static IPlayersHand players_hand;
        private static IPlayer player;
    }
}
