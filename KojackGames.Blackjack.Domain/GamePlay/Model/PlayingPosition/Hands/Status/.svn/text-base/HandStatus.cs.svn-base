namespace KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status
{   
    public class HandStatus
    {
        public static InPlay in_play = new InPlay();
        public static Bust bust = new Bust();
        public static Stick stick = new Stick();
        public static BlackJack blackjack = new BlackJack();
        public static Lost lost = new Lost();
        public static Won won = new Won();
        public static SoftBlackJack soft_blackjack = new SoftBlackJack();
        public static Push push = new Push();

        public int id { get; set; }   
        public bool turn_ended { get; set;}
        public string name { get; set; }

        private HandStatus()
        {                
        }

        protected HandStatus(int id, bool can_take_card, string name)   
        {       
            this.id = id;       
            this.turn_ended = can_take_card;       
            this.name = name;   
        }

        public bool Equals(HandStatus other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.id == id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (HandStatus)) return false;
            return Equals((HandStatus) obj);
        }

        public override int GetHashCode()
        {
            return id;
        }
    }

    public class InPlay : HandStatus
    {
        public InPlay()
            : base(1, false, "In play")
        { }
    }

    public class Bust: HandStatus
    {
        public Bust()
            : base(2, true, "Bust")
        { }
    }

    public class Stick : HandStatus
    {
        public Stick()
            : base(3, true, "Stick")
        { }
    } 
        
    public class BlackJack: HandStatus
    {
        public BlackJack()
            : base(4, true, "BlackJack")
        { }
    } 
    
    public class Lost: HandStatus
    {
        public Lost()
            : base(5, true, "Lost")
        { }
    }

    public class Won : HandStatus
    {
        public Won()
            : base(6, true, "Won")
        { }
    }

    public class SoftBlackJack : HandStatus
    {
        public SoftBlackJack()
            : base(7, true, "Soft BlackJack")
        { }
    }    

    public class Push : HandStatus
    {
        public Push()
            : base(8, true, "Push")
        { }
    }
}
