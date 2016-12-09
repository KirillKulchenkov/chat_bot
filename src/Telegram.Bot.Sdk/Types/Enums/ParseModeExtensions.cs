using System.Collections.Generic;

namespace Telegram.Bot.Types.Enums
{
    internal static class ParseModeExtensions
    {
        internal static readonly Dictionary<ParseMode, string> StringMap =
            new Dictionary<ParseMode, string>
            {
                {ParseMode.Default, null },
                {ParseMode.Markdown, "Markdown" },
                {ParseMode.Html, "HTML" },
            };

        public static string ToModeString(this ParseMode mode) => StringMap[mode];
    }
}