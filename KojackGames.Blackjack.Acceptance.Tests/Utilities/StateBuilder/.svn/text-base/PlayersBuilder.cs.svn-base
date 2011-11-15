using System;
using System.Linq;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using NHibernate.Linq;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder
{
    public class PlayersBuilder
    {
        private PlayerTableRow _player_row;

        public PlayersBuilder create_player_with_id_of(Guid player_id)
        {
            _player_row = new PlayerTableRow();
            _player_row.player_token = player_id;
            _player_row.dollars_in_pot = 0;
            _player_row.version = 0;

            return this;
        }

        public PlayersBuilder find_player_with_id_of(Guid player_id)
        {
            using (var session = SessionFactory.GetNewSession())
            {
                _player_row = session.Query<PlayerTableRow>().Where(x => x.player_token == player_id).SingleOrDefault();
            }

            return this;
        }

        public PlayersBuilder set_pot_to(decimal dollars)
        {
            _player_row.dollars_in_pot = dollars;

            return this;
        }

        public PlayerTableRow build()
        {
            return _player_row;
        }
    }
}
