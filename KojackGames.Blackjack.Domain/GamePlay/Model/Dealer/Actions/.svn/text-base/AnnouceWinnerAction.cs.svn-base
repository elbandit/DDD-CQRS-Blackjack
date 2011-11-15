using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership.Events;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure.Domain;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class AnnouceWinnerAction : IAnnouceWinnerAction
    {
        private readonly IHandScorer _hand_scorer;

        public AnnouceWinnerAction(IHandScorer hand_scorer)
        {
            _hand_scorer = hand_scorer;
        }

        public void determine_winner_from(IPlayingPositions playing_positions, IPlayer player)
        {
            var dealers_hand = playing_positions.dealers_hand;
            
            dealers_hand.show_card_in_hole();

            foreach (var players_hand in playing_positions.players_hands())
            {
                if (players_hand.has_status_of(HandStatus.blackjack) && dealers_hand.has_status_of(HandStatus.blackjack))
                {
                    players_hand.change_state_to(HandStatus.push);
                }
                else if (players_hand.has_status_of(HandStatus.blackjack))
                {
                    players_hand.change_state_to(HandStatus.won);
                }
                else if (dealers_hand.has_status_of(HandStatus.blackjack))
                {
                    players_hand.change_state_to(HandStatus.lost);
                }
                else if (players_hand.has_status_of(HandStatus.soft_blackjack) &&
                         dealers_hand.has_status_of(HandStatus.soft_blackjack))
                {
                    players_hand.change_state_to(HandStatus.push);
                }
                else if (players_hand.has_status_of(HandStatus.soft_blackjack))
                {
                    players_hand.change_state_to(HandStatus.won);
                }
                else if (dealers_hand.has_status_of(HandStatus.soft_blackjack))
                {
                    players_hand.change_state_to(HandStatus.lost);
                }
                else if (players_hand.has_status_of(HandStatus.bust) && dealers_hand.has_status_of(HandStatus.bust))
                {
                    players_hand.change_state_to(HandStatus.push);
                }
                else if (players_hand.has_status_of(HandStatus.bust))
                {
                    players_hand.change_state_to(HandStatus.lost);
                }
                else if (dealers_hand.has_status_of(HandStatus.bust))
                {
                    players_hand.change_state_to(HandStatus.won);
                }
                else if (players_hand.has_status_of(HandStatus.stick))
                {
                    var player_score = _hand_scorer.calculate_score_for(players_hand);
                    var dealers_score = _hand_scorer.calculate_score_for(dealers_hand);

                    if (player_score > dealers_score)
                    {
                        players_hand.change_state_to(HandStatus.won);
                    }
                    else if (player_score < dealers_score)
                    {
                        players_hand.change_state_to(HandStatus.lost);
                    }
                    else if (player_score == dealers_score)
                    {
                        players_hand.change_state_to(HandStatus.push);
                    }
                }

                var chips_to_give_to_player = new Chips(0m);

                // Check if dealer has blackjack and that player took insurnace
                if (players_hand.has_taken_insurance() && dealers_hand.has_status_of(HandStatus.blackjack))
                {
                    var original_insurance_amount = players_hand.wager.halved();

                    var winnings = original_insurance_amount.mulitple_by_odds_of(2, 1);

                    chips_to_give_to_player = chips_to_give_to_player.add(original_insurance_amount.add(winnings));
                }

                if (players_hand.has_status_of(HandStatus.won))
                {
                    chips_to_give_to_player = chips_to_give_to_player.add(players_hand.wager.mulitple_by_odds_of(3, 2).add(players_hand.wager));
                    DomainEvents.raise(new HandResultEvent(string.Format("Hand {0} Won - you win {1}", players_hand.get_hand_letter(), chips_to_give_to_player.ToString())));
                    player.increase_pot_by(chips_to_give_to_player);                    
                }

                if (players_hand.has_status_of(HandStatus.push))
                {
                    chips_to_give_to_player = chips_to_give_to_player.add(players_hand.wager);
                    player.increase_pot_by(chips_to_give_to_player); 

                    DomainEvents.raise(new HandResultEvent(string.Format("Hand {0} tied with the dealer, you get {1}", players_hand.get_hand_letter(), chips_to_give_to_player.ToString())));                                                           
                }

                if (players_hand.has_status_of(HandStatus.lost))
                {
                    if (chips_to_give_to_player.contains_chips())
                    {
                        player.increase_pot_by(chips_to_give_to_player); 
                        DomainEvents.raise(new HandResultEvent(string.Format("Hand {0} lost, but you won insurance bet of {1}", players_hand.get_hand_letter(), chips_to_give_to_player.ToString())));
                    }
                    else
                    {
                        DomainEvents.raise(new HandResultEvent(string.Format("Hand {0} lost", players_hand.get_hand_letter())));
                    }
                }
            }
        }       
    }
}
