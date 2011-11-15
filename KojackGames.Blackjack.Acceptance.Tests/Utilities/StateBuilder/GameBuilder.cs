using System;
using System.Collections.Generic;
using System.Linq;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using NHibernate.Linq;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder
{
    public class GameBuilder
    {
        private BlackJackTableRow _blackjacktablerow; 

        public GameBuilder create_for(Guid player_id)
        {
            _blackjacktablerow = new BlackJackTableRow();
            _blackjacktablerow.id = Guid.NewGuid();
            _blackjacktablerow.cards_dealt = false;
            _blackjacktablerow.hand_rows = new List<HandTableRow>();
            _blackjacktablerow.deck_rows = new List<DeckRow>();
            _blackjacktablerow.player_token = player_id;

            return this;
        }

        public HandBuilder add_hand_with_bet_of(decimal bet_amount)
        {
            var handTableRow = new HandTableRow();
            handTableRow.id = Guid.NewGuid();
            handTableRow.bet = bet_amount;
            handTableRow.hand_letter = "A";
            handTableRow.blackjacktable = _blackjacktablerow;
            handTableRow.discriminator = "Player";
            handTableRow.card_in_hand_rows = new List<CardInHandRow>();
            _blackjacktablerow.hand_rows.Add(handTableRow);

            return new HandBuilder(handTableRow, this);
        }

        public BlackJackTableRow build()
        {            
            return _blackjacktablerow;
        }

        public GameBuilder find_game_by_player_id(Guid player_id)
        {
            using (var session = SessionFactory.GetNewSession())
            {
                _blackjacktablerow = session.Query<BlackJackTableRow>().Where(x => x.player_token == player_id).SingleOrDefault();     
            }

            return this;
        }

        public GameBuilder add_to_deck(DeckRow card)
        {
            card.blackjacktable_id = _blackjacktablerow.id;
            _blackjacktablerow.deck_rows.Add(card);

            return this;
        }

        public GameBuilder mark_cards_as_dealt()
        {
            _blackjacktablerow.cards_dealt = true;
            return this;
        }

        public GameBuilder set_game_state_to(TableStatus table_status)
        {
            _blackjacktablerow.can_accept_bet = table_status.can_accept_bet;
            _blackjacktablerow.can_deal = table_status.can_deal;
            _blackjacktablerow.state_id = table_status.id;
            _blackjacktablerow.state_name = table_status.name;

            return this;
        }
        
        public HandBuilder for_players_hand()
        {
            return new HandBuilder(_blackjacktablerow.hand_rows.Where(x => x.discriminator == "Player").FirstOrDefault(), this);
        }

        public GameBuilder add_cards_to_dealers_hand(List<CardInHandRow> cards)
        {
            var dealers_hand = _blackjacktablerow.hand_rows.Where(x => x.discriminator == "Dealer").FirstOrDefault();
            
            foreach (var card in cards)
            {
                card.hand_id = dealers_hand.id;
                dealers_hand.card_in_hand_rows.Add(card);
            }              

            return this;
        }
       
        public DealersHandBuilder add_dealers_hand()
        {
            var dealers_hand = new HandTableRow();

            dealers_hand.id = Guid.NewGuid();
            dealers_hand.discriminator = "Dealer";
            dealers_hand.card_in_hand_rows = new List<CardInHandRow>();
            dealers_hand.blackjacktable = _blackjacktablerow;

            _blackjacktablerow.hand_rows.Add(dealers_hand);
            return new DealersHandBuilder(dealers_hand, this);
        }
    }
}