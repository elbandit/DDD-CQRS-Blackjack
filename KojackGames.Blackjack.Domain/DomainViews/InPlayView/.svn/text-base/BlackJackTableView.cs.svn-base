using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Infrastructure.Helpers;

namespace KojackGames.Blackjack.Domain.DomainViews.InPlayView
{
    public class BlackJackTableView
    {                        
        public Guid id { get; set; }
        public int version { get; set; }       
        public IList<HandView> all_hands { get; set; }

        public Guid player_token { get; set; }
        public bool finished { get; set; }
        public bool can_accept_bet { get; set; }
        public bool can_deal { get; set; }
   
        public HandView dealers_hand
        {
            get { return all_hands.Where(x => x.is_type_of<DealersHandView>()).Cast<DealersHandView>().First(); }
        }

        public IEnumerable<PlayersHandView> players_hands
        {
            get { return all_hands.Where(x => x.is_type_of<PlayersHandView>()).Cast<PlayersHandView>(); }
        }

        public bool has_game_started { get; set; }
        public string game_message { get; set; }
        public decimal dollars_in_pot { get; set; }

        public string dollars_in_pot_formatted
        {
            get { return string.Format("${0:0.00}", dollars_in_pot); }
        }
    }
}