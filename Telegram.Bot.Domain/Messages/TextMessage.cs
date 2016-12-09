using System;
using Telegram.Bot.Types;

namespace Telegram.Bot.Domain.Messages
{
    public class TextMessage : IMessage
    { 
        public string Text { get; set; }
        public User From { get; set; }
        public DateTime Date { get; set; }
    }
}