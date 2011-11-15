using System;

namespace KojackGames.Blackjack.UI.Web.Models
{
    public interface ICommandMapper<out TCommand, in TFrom>
    {
        TCommand map_from(TFrom view_model, Guid player_token);
    }
}