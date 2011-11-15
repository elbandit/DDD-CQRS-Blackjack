using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.Membership.Events;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.Membership.Model
{
    public class Player : DomainBase<Player>, IEntity, IPlayer
    {        
        public Player(Guid player_token, string name)
        {
            this.name = name;
            this.id = player_token;
            dollars_in_pot = 0;

            DomainEvents.raise(new PlayerRegisteredEvent());
        }

        private Player()
        {
                
        }

        public decimal dollars_in_pot { get; set; }
        public string name { get; set; }

        public bool can_afford_to_bet(Chips wager)
        {
            return dollars_in_pot >= wager.value;
        }

        public void decrease_pot_by(Chips wager)
        {
            if (can_afford_to_bet(wager))
            {
                dollars_in_pot -= wager.value;
            }
        }

        public void increase_pot_by(Chips wager)
        {
            dollars_in_pot += wager.value;
        }

        public BlackJackTable current_game { get; set; }
    }
}
