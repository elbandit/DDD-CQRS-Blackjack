namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Player
{
    public interface IPlayersHand: IHand
    {
        Chips wager { get; }                
        IPlayersHand split_hand();
        
        void mark_as_active();
        void mark_as_inactive();
        bool is_active { get; }

        void mark_as_taken_insurance();        

        void mark_as_able_to_double_down();
        void mark_as_able_to_split();
        void mark_as_able_to_take_insurance();

        void remove_offer_to_double_down();
        void remove_offer_to_split();
        void remove_offer_to_take_insurance();

        void double_stake();
        string get_hand_letter();
        bool has_taken_insurance();
    }
}