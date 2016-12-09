using System;
using Telegram.Bot.Types;

namespace Telegram.Bot.Domain.Messages
{
    public class LoacationMessage : IMessage
    {
        public User From { get; set; }
        public DateTime Date { get; set; }
        public Location Location { get; set; }
    }
}