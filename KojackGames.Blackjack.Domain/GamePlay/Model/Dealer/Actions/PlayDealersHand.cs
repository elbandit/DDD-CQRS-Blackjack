using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions
{
    public class PlayDealersHand : IPlayDealersHand
    {
        private readonly ICanHitDealerSpecification _can_hit_dealer;
        private readonly IHandStatusFactory _hand_status_factory;

        public PlayDealersHand(ICanHitDealerSpecification can_hit_dealer, IHandStatusFactory hand_status_factory)
        {
            _can_hit_dealer = can_hit_dealer;
            _hand_status_factory = hand_status_factory;
        }

        public void draw_cards_for_dealer_in(IPlayingPositions hands, ICardShoe card_shoe)
        {
            var dealers_hand = hands.dealers_hand;
            while (_can_hit_dealer.is_satisfied_by(dealers_hand))
            {
                dealers_hand.add(card_shoe.take_card());
                _hand_status_factory.set_status_for(dealers_hand);
            }
        }
    }
}
