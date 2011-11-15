using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public class WebSiteFileLocation
    {
        private const string relative_path = @"KojackGames.Blackjack.UI.Web";

        public static string get_physical_path()
        {
            var dir = Directory.GetCurrentDirectory();

            var index = dir.LastIndexOf("KojackGames.Blackjack.Acceptance.Tests");

            dir = dir.Remove(index);

            return Path.Combine(dir, relative_path);
        }
    }
}
