using System;
using Telegram.Bot.Types;

namespace Telegram.Bot.Domain.Messages
{
    public class PhotoMessage : IMessage
    {
        public File Photos { get; set; }
        public User From { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}