using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Infrastructure.Helpers;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition
{    
    public class PlayingPositions : IPlayingPositions
    {
        private readonly IHandFactory _hand_factory;
        private bool _cards_dealt;
        private IList<IHand> _hands;

        private PlayingPositions()
        {
            _hand_factory = new HandFactory();
        }

        public PlayingPositions(IHandFactory hand_factory) 
        {
            _cards_dealt = false;
            _hand_factory = hand_factory;            
            _hands = new List<IHand>();
        }        
                                         
        public IEnumerable<IHand> all_hands
        {
            get { return _hands; }
        }

        public IDealersHand dealers_hand
        {
            get {
                if (_hands.Where(x => x.is_type_of<DealersHand>()).FirstOrDefault() != null)
                    return _hands.Where(x => x.is_type_of<DealersHand>()).Cast<IDealersHand>().First();
                else
                    return null;
            }
        }
      
        public IPlayersHand players_active_hand
        {
            get
            {
                if (_hands.Where(x => x.is_type_of<PlayersHand>()).FirstOrDefault() != null)
                    return
                        _hands.Where(x => x.is_type_of<PlayersHand>()).Cast<IPlayersHand>().Where(
                            x => x.is_active).FirstOrDefault();
                else
                    return null;                
            }
        }

        public bool player_has_blackjack()
        {
            return players_hands().Count(x => x.has_status_of(HandStatus.blackjack)) > 0;
        }

        public bool has_free_position_for_bet()
        {
            return (players_active_hand == null) ;
        }

        public bool have_cards_been_dealt()
        {
            return _cards_dealt;
        }

        public void mark_cards_as_dealt()
        {
            _cards_dealt = true;
        }

        public bool player_has_finished()
        {
            return players_hands().Where(x => !x.turn_ended()).Count() == 0;
        }

        public void split_players_hand()
        {            
            _hands.Add(players_active_hand.split_hand());
        }

        public IEnumerable<IPlayersHand> players_hands()
        {
            return _hands.Where(x => x.is_type_of<PlayersHand>()).Cast<IPlayersHand>();
        }

        public void clear_all_first_hand_decision_offers()
        {
            foreach(var hand in players_hands())
            {
                hand.remove_offer_to_double_down();
                hand.remove_offer_to_split();
                hand.remove_offer_to_take_insurance();
            }
        }

        public void update_active_hand()
        {
            if (players_active_hand.turn_ended())
            {
                var has_set_active_hand = false;

                foreach(var hand in _hands.Where(x => x.is_type_of<PlayersHand>()).Cast<IPlayersHand>())
                {
                    if (hand.is_active && hand.turn_ended())                
                        hand.mark_as_inactive();

                    if (!hand.is_active && !hand.turn_ended() && !has_set_active_hand)
                    {    
                        hand.mark_as_active();
                        has_set_active_hand = true;
                    }
                }
            }
            
         }        

        public void place_bet_on_free_position(Chips chips_wagered, BlackJackTable black_jack_table)
        {
            if (players_active_hand == null)
                _hands.Add(_hand_factory.create_players_hand_with(chips_wagered, black_jack_table, HandLetters.A.ToString()));            
        }
                        
        public void create_dealers_hand_for(BlackJackTable black_jack_table)
        {
            if (dealers_hand == null)
                _hands.Add(_hand_factory.create_dealers_hand_for(black_jack_table));
        }        
    }
}
