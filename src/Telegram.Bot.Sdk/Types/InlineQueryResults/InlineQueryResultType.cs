namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Type of the InlineQueryResult
    /// </summary>
    public enum InlineQueryResultType
    {
        /// <summary>
        /// Unknown <see cref="InlineQueryResultType"/>
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// <see cref="InlineQueryResultArticle"/>
        /// </summary>
        Article,
        /// <summary>
        /// <see cref="InlineQueryResultPhoto"/>
        /// </summary>
        Photo,
        /// <summary>
        /// <see cref="InlineQueryResultGif"/>
        /// </summary>
        Gif,
        /// <summary>
        /// <see cref="InlineQueryResultMpeg4Gif"/>
        /// </summary>
        Mpeg4Gif,
        /// <summary>
        /// <see cref="InlineQueryResultVideo"/>
        /// </summary>
        Video,

        /// <summary>
        /// <see cref="InlineQueryResultAudio"/>
        /// </summary>
        Audio,
        /// <summary>
        /// <see cref="InlineQueryResultContact"/>
        /// </summary>
        Contact,
        /// <summary>
        /// <see cref="InlineQueryResultDocument"/>
        /// </summary>
        Document,
        /// <summary>
        /// <see cref="InlineQueryResultLocation"/>
        /// </summary>
        Location,
        /// <summary>
        /// <see cref="InlineQueryResultVenue"/>
        /// </summary>
        Venue,
        /// <summary>
        /// <see cref="InlineQueryResultVoice"/>
        /// </summary>
        Voice,
        /// <summary>
        /// <see cref="InlineQueryResultGame"/>
        /// </summary>
        Game,

        /// <summary>
        /// <see cref="InlineQueryResultCachedPhoto"/>
        /// </summary>
        CachedPhoto = 102,
        /// <summary>
        /// <see cref="InlineQueryResultCachedMpeg4Gif"/>
        /// </summary>
        CachedGif = 103,
        /// <summary>
        /// <see cref="InlineQueryResultCachedVideo"/>
        /// </summary>
        CachedMpeg4Gif = 104,
        /// <summary>
        /// <see cref="InlineQueryResultCachedAudio"/>
        /// </summary>
        CachedVideo = 105,
        /// <summary>
        /// <see cref="InlineQueryResultCachedAudio"/>
        /// </summary>
        CachedAudio = 106,
        /// <summary>
        /// <see cref="InlineQueryResultCachedDocument"/>
        /// </summary>
        CachedDocument = 108,
        /// <summary>
        /// <see cref="InlineQueryResultCachedVoice"/>
        /// </summary>
        CachedVoice = 111,

        /// <summary>
        /// <see cref="InlineQueryResultCachedSticker"/>
        /// </summary>
        CachedSticker = 112,
    }
}
