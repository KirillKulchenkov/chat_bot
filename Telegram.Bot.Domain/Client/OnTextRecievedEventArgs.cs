using Telegram.Bot.Domain.Messages;

namespace Telegram.Bot.Domain.Client
{
    public class OnTextRecievedEventArgs : OnMessageRecievedEventArgs<TextMessage>
    {
        public OnTextRecievedEventArgs(TextMessage msg) : base(msg)
        {
        }
    }
}