using System;
using KojackGames.Blackjack.Domain.GamePlay.Commands;
using KojackGames.Blackjack.UI.Web.Controllers;
using KojackGames.Blackjack.UI.Web.Models.ViewModels;

namespace KojackGames.Blackjack.UI.Web.Models
{
    public class BetCommandMapper : ICommandMapper<BetCommand, BetView>
    {
        public BetCommand map_from(BetView view_model, Guid player_token)
        {
            // TODO: validate first.....
            return new BetCommand()
                       {
                           wager = view_model.bet,
                           player_token = player_token
                       };
        }
    }
}