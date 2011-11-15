using System;
using System.Collections.Generic;

namespace KojackGames.Blackjack.Domain.DomainViews.InPlayView
{
    public abstract class HandView
    {
        public Guid id { get; set; }
        public IList<CardView> cards { get; set; }
        public string state { get; set; }
    }
}