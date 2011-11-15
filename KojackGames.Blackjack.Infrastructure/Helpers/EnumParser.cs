using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Helpers
{
    public class EnumParser
    {
        public static T parse_enum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
