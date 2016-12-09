using System;
using Telegram.Bot.Domain.Messages;

namespace Telegram.Bot.Domain.Client
{
    public abstract class OnMessageRecievedEventArgs<T> : EventArgs where T : IMessage
    {
        public T Message { get; set; }

        protected OnMessageRecievedEventArgs(T msg)
        {
            Message = msg;
        }
    }
}