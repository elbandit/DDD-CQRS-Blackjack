using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;

namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status
{
    public class HandStatusFactory : IHandStatusFactory
    {
        private readonly IHasBlackjackSpecification _has_blackjack_spec;
        private readonly IHasBustedSpecification _has_bust_spec;
        private readonly IHasSoftBlackJackSpecification _has_soft_blackjack_spec;

        public HandStatusFactory(IHasBlackjackSpecification has_blackjack_spec, 
                                 IHasBustedSpecification has_bust_spec, 
                                 IHasSoftBlackJackSpecification has_soft_blackjack_spec)
        {
            _has_blackjack_spec = has_blackjack_spec;
            _has_soft_blackjack_spec = has_soft_blackjack_spec;
            _has_bust_spec = has_bust_spec;
        }

        public void set_status_for(IHand hand)
        {
            if (_has_blackjack_spec.is_satisfied_by(hand))
                hand.change_state_to(HandStatus.blackjack);

            if (_has_bust_spec.is_satisfied_by(hand))
                hand.change_state_to(HandStatus.bust);

            if (_has_soft_blackjack_spec.is_satisfied_by(hand))
                hand.change_state_to(HandStatus.soft_blackjack);
        }
    }
}
