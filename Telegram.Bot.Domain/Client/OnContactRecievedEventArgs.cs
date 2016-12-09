using Telegram.Bot.Domain.Messages;

namespace Telegram.Bot.Domain.Client
{
    public class OnContactRecievedEventArgs : OnMessageRecievedEventArgs<ContactMessage>
    {
        public OnContactRecievedEventArgs(ContactMessage msg) : base(msg)
        {
        }
    }
}