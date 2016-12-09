using Telegram.Bot.Domain.Messages;

namespace Telegram.Bot.Domain.Client
{
    public class OnPhotoRecievedEventArgs : OnMessageRecievedEventArgs<PhotoMessage>
    {
        public OnPhotoRecievedEventArgs(PhotoMessage msg) : base(msg)
        {
        }
    }
}