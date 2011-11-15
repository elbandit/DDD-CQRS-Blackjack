using System.Collections.Generic;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DetermineWinner
{
    [Subject(typeof(AnnouceWinnerAction))]
    public class when_a_player_and_dealer_have_bust : with_AnnouceWinnerAction
    {
        private Establish context = () =>
        {
            player = MockRepository.GenerateStub<IPlayer>();
            players_hand = MockRepository.GenerateStub<IPlayersHand>();
            players_hand.Stub(x => x.has_status_of(HandStatus.bust)).Return(true);
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();
            dealers_hand.Stub(x => x.has_status_of(HandStatus.bust)).Return(true);

            playing_positions = MockRepository.GenerateStub<IPlayingPositions>();
            playing_positions.Stub(x => x.players_hands()).Return(new List<IPlayersHand>(){players_hand});
            playing_positions.Stub(x => x.dealers_hand).Return(dealers_hand);
        };

        private Because of = () => SUT.determine_winner_from(playing_positions, player);

        private It should_set_the_players_hand_as_push = () => players_hand.AssertWasCalled(x => x.change_state_to(HandStatus.push));
        
        private static IPlayingPositions playing_positions;
        private static IPlayersHand players_hand;
        private static IDealersHand dealers_hand;
        private static IPlayer player;
    }
}
