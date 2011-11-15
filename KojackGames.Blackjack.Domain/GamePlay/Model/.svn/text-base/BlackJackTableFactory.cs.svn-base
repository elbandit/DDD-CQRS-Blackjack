using System;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.Membership.Model;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public class BlackJackTableFactory : IBlackJackTableFactory
    {
        public BlackJackTable create_for(Player player)
        {
            return new BlackJackTable(player, new CardShoe(new Deck()), new PlayingPositions(new HandFactory()), TableStatus.empty_table);
        }
    }
}