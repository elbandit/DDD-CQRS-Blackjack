using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Infrastructure.Helpers
{
    public static class ComparisonExtensions
    {
        public static bool implements_interface<TInterface>(this object object_to_compare)
        {
            return typeof (TInterface).IsAssignableFrom(object_to_compare.GetType());
        }

        public static bool is_type_of<TType>(this object object_to_compare)
        {
            return object_to_compare.GetType() == typeof(TType);
        }
    }
}
