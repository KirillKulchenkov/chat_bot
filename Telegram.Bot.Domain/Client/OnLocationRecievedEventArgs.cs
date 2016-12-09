using Telegram.Bot.Domain.Messages;

namespace Telegram.Bot.Domain.Client
{
    public class OnLocationRecievedEventArgs : OnMessageRecievedEventArgs<LoacationMessage>
    {
        public OnLocationRecievedEventArgs(LoacationMessage msg) : base(msg)
        {
        }
    }
}