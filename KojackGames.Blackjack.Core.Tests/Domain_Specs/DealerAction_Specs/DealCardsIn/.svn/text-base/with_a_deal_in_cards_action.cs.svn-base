using System.Collections.Generic;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Model;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.DealerAction_Specs.DealCardsIn
{
    public abstract class with_a_deal_in_cards_action
    {
        protected static Domain.GamePlay.Model.Dealer.Actions.DealCardsIn SUT;
        protected static IAnnouceWinnerAction annouce_winner_action;
        protected static IHandStatusFactory hand_status_factory;

        protected static IPlayer player;
        protected static IPlayingPositions positions;
        protected static IPlayersHand players_hand;
        protected static IDealersHand dealers_hand;
        protected static List<IHand> hands;
        protected static IHand hand;
        protected static ICardShoe card_shoe;
        protected static ICanDoubleDown double_down_spec;
        protected static ICanSplit split_spec;
        protected static ICanTakeInsurance insurance_spec;

        public with_a_deal_in_cards_action()
        {
            double_down_spec = MockRepository.GenerateStub<ICanDoubleDown>();
            split_spec = MockRepository.GenerateStub<ICanSplit>();
            insurance_spec = MockRepository.GenerateStub<ICanTakeInsurance>();

            card_shoe = MockRepository.GenerateStub<ICardShoe>();
            positions = MockRepository.GenerateStub<IPlayingPositions>();

            player = MockRepository.GenerateStub<IPlayer>();

            players_hand = MockRepository.GenerateStub<IPlayersHand>();
            positions.Stub(x => x.players_active_hand).Return(players_hand);
            dealers_hand = MockRepository.GenerateStub<IDealersHand>();
            positions.Stub(x => x.dealers_hand).Return(dealers_hand);

            hand = MockRepository.GenerateStub<IHand>();
            hands = new List<IHand>() { hand };
            positions.Stub(x => x.all_hands).Return(hands);

            hand_status_factory = MockRepository.GenerateStub<IHandStatusFactory>();
            annouce_winner_action = MockRepository.GenerateStub<IAnnouceWinnerAction>();

            SUT = new Domain.GamePlay.Model.Dealer.Actions.DealCardsIn(hand_status_factory, 
                                                                       annouce_winner_action,
                                                                       double_down_spec,
                                                                       split_spec,
                                                                       insurance_spec);
        }
    }
}