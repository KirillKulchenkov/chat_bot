using System;
using Telegram.Bot.Types;

namespace Telegram.Bot.Domain.Messages
{
    public class ContactMessage : IMessage
    {
        public User From { get; set; }
        public DateTime Date { get; set; }

        public Contact Contact { get; set; }
    }
}