using System;
using System.Collections.Generic;

namespace Telegram.Bot.Types.Enums
{
    internal static class MessageTypeExtension
    {
        internal static KeyValuePair<string, string> ToKeyValue(this MessageType type)
        {
            switch (type)
            {
                case MessageType.TextMessage:
                    return new KeyValuePair<string, string>("sendMessage", "text");
                case MessageType.PhotoMessage:
                    return new KeyValuePair<string, string>("sendPhoto", "photo");
                case MessageType.AudioMessage:
                    return new KeyValuePair<string, string>("sendAudio", "audio");
                case MessageType.VideoMessage:
                    return new KeyValuePair<string, string>("sendVideo", "video");
                case MessageType.VoiceMessage:
                    return new KeyValuePair<string, string>("sendVoice", "voice");
                case MessageType.DocumentMessage:
                    return new KeyValuePair<string, string>("sendDocument", "document");
                case MessageType.StickerMessage:
                    return new KeyValuePair<string, string>("sendSticker", "sticker");
                case MessageType.LocationMessage:
                    return new KeyValuePair<string, string>("sendLocation", "latitude");
                case MessageType.ContactMessage:
                    return new KeyValuePair<string, string>("sendContact", "phone_number");
                case MessageType.VenueMessage:
                    return new KeyValuePair<string, string>("sendVenue", "latitude");
                case MessageType.GameMessage:
                    return new KeyValuePair<string, string>("sendGame", "game_short_name");

                default:
                    throw new NotImplementedException();
            }
        } 
    }
}