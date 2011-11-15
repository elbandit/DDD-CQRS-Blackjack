using System;

namespace KojackGames.Blackjack.Domain.DomainViews.InPlayView
{
    public class PlayersHandView : HandView
    {        
        public bool turn_ended { get; set; }                                                   
        public decimal wager { get; set; }
        public bool can_double_down { get; set; }
        public bool can_split { get; set; }
        public bool can_take_insurance { get; set; }
        public bool has_taken_insurance { get; set; }
        public string hand_letter { get; set; }
        public bool is_active { get; set; }

        public string wager_formatted
        {
            get { return string.Format("${0:0.00}", wager); }
        }
    }
}
