using System.Collections.Generic;

namespace Telegram.Bot.Types.InlineQueryResults
{
    internal static class InlineQueryResultTypeExtension
    {
        private static readonly Dictionary<InlineQueryResultType, string> StringMap =
            new Dictionary<InlineQueryResultType, string>
            {
                {InlineQueryResultType.Article, "article" },
                {InlineQueryResultType.Audio, "audio" },
                {InlineQueryResultType.Contact, "contact" },
                {InlineQueryResultType.Document, "document" },
                {InlineQueryResultType.Game, "game" },
                {InlineQueryResultType.Gif, "gif" },
                {InlineQueryResultType.Location, "location" },
                {InlineQueryResultType.Mpeg4Gif, "mpeg4_gif" },
                {InlineQueryResultType.Photo, "photo" },
                {InlineQueryResultType.Venue, "venue" },
                {InlineQueryResultType.Video, "video" },
                {InlineQueryResultType.Voice,  "voice" },

                {InlineQueryResultType.CachedAudio, "audio" },
                {InlineQueryResultType.CachedDocument, "document" },
                {InlineQueryResultType.CachedGif, "gif" },
                {InlineQueryResultType.CachedMpeg4Gif, "mpeg4_gif" },
                {InlineQueryResultType.CachedPhoto, "photo" },
                {InlineQueryResultType.CachedSticker, "sticker" },
                {InlineQueryResultType.CachedVideo, "video" },
                {InlineQueryResultType.CachedVoice, "voice" },
            };

        internal static string ToTypeString(this InlineQueryResultType type) => StringMap[type];
    }
}