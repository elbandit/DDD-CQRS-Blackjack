using System;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using Machine.Specifications;
using Rhino.Mocks;

namespace KojackGames.Blackjack.Core.Tests.Domain_Specs.BlackJackTable_Specs
{
    [Subject(typeof(BlackJackTable), "BlackJack table")]
    public abstract class on_a_blackjacktable
    {
        protected static BlackJackTable SUT;
        protected static IPlayer player;        
        protected static ICardShoe card_shoe;
        protected static IPlayingPositions playing_positions;
        protected static ITableStatus table_status;

        public on_a_blackjacktable()
        {            
            card_shoe = MockRepository.GenerateStub<ICardShoe>();
            playing_positions = MockRepository.GenerateStub<IPlayingPositions>();
            table_status = MockRepository.GenerateStub<ITableStatus>();
            player = MockRepository.GenerateStub<IPlayer>();

            SUT = new BlackJackTable(player, card_shoe, playing_positions, table_status);
        }
    }
}