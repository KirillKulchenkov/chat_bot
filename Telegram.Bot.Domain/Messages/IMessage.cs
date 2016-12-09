using System;
using Telegram.Bot.Types;

namespace Telegram.Bot.Domain.Messages
{
    public interface IMessage
    {
        User From { get; set; }
        DateTime Date { get; set; }
        
    }
}