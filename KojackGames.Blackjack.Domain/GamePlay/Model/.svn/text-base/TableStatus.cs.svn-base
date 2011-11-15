using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Domain.GamePlay.Model
{
    public class TableStatus : ITableStatus
    {       
        public static EmptyTable empty_table = new EmptyTable();
        public static FullTable full_table = new FullTable();
        public static HandsDealt hands_dealt = new HandsDealt();
        public static GameFinished game_finished = new GameFinished();
        public static HandsDealt in_play = new HandsDealt();
        
        public int id { get; private set; }
        public bool can_accept_bet { get; private set; }
        public bool can_deal { get; private set; }
        public bool finished { get; private set; }
        public string name { get; private set; }
        
        public TableStatus()
        {
        }

        protected TableStatus(int id, bool can_accept_bet, bool can_deal, bool finished, string name)
        {
            this.id = id;
            this.can_accept_bet = can_accept_bet;
            this.can_deal = can_deal;
            this.finished = finished;

            this.name = name;
        }

        public bool Equals(TableStatus other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.id == id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (TableStatus)) return false;
            return Equals((TableStatus) obj);
        }

        public override int GetHashCode()
        {
            return id;
        }
    }

    public class EmptyTable : TableStatus
    {
        public EmptyTable()
            : base(1, true, false, false, "Empty Table")
        { }
    }

    public class FullTable : TableStatus
    {
        public FullTable()
            : base(2, false, true, false, "Full Table")
        { }
    }

    public class HandsDealt : TableStatus
    {
        public HandsDealt()
            : base(3, false, false, false, "Hand Dealt")
        { }
    }

    public class GameFinished : TableStatus
    {
        public GameFinished()
            : base(4, false, false, true, "Game Finished")
        { }
    } 
}
