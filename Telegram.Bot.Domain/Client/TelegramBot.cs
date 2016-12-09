using System;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Domain.Messages;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Domain.Client
{
    public class TelegramBot
    {
        public TelegramBotClient Bot { get; }
        public event EventHandler<OnTextRecievedEventArgs> OnTextMessageRecieved;
        public event EventHandler<OnPhotoRecievedEventArgs> OnPhotoMessageRecieved;
        public event EventHandler<OnLocationRecievedEventArgs> OnLocationMessageRecieved;
        public event EventHandler<OnContactRecievedEventArgs> OnContactMessageRecieved;  
        public TelegramBot(string apiKey)
        {
            Bot = new TelegramBotClient(apiKey);
            Bot.OnMessage += async delegate(object sender, MessageEventArgs args) { await BotOnOnMessage(sender, args); };
            Bot.OnInlineQuery += BotOnOnInlineQuery;
            Bot.OnCallbackQuery += BotOnOnCallbackQuery;
        }

        public void Start()
        {
            Bot.StartReceiving();
        }

        private void BotOnOnCallbackQuery(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            Console.WriteLine(callbackQueryEventArgs.CallbackQuery.Data);
            return;
        }

        private void BotOnOnInlineQuery(object sender, InlineQueryEventArgs inlineQueryEventArgs)
        {
            Console.WriteLine(inlineQueryEventArgs.InlineQuery.Query);
            return;
        }

        private async Task BotOnOnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Console.WriteLine(messageEventArgs.Message.Text);
            switch (messageEventArgs.Message.Type)
            {
                case MessageType.PhotoMessage:
                {
                    var photo =
                        await
                            Bot.GetFileAsync(
                                messageEventArgs.Message.Photo[messageEventArgs.Message.Photo.Length - 1].FileId);
                    OnOnPhotoMessageRecieved(messageEventArgs.Message, photo);
                    break;
                }
                case MessageType.LocationMessage:
                {
                    OnOnLocationMessageRecieved(messageEventArgs.Message);
                    break;
                }
                case MessageType.TextMessage:
                {
                    OnOnTextMessageRecieved(messageEventArgs.Message);
                    break;
                }
            }
            return;
        }

        protected virtual void OnOnTextMessageRecieved(Message msg)
        {
            OnTextMessageRecieved?.Invoke(this, new OnTextRecievedEventArgs(new TextMessage()
            {
                Date = msg.Date,
                Text = msg.Text,
                From = msg.From
            }));
        }

        protected virtual void OnOnPhotoMessageRecieved(Message msg, File photo)
        {
            OnPhotoMessageRecieved?.Invoke(this, new OnPhotoRecievedEventArgs(new PhotoMessage()
            {
                Date = msg.Date,
                Photos = photo,
                From = msg.From,
                Description = msg.Caption
            }));
        }

        protected virtual void OnOnLocationMessageRecieved(Message msg)
        {
            OnLocationMessageRecieved?.Invoke(this, new OnLocationRecievedEventArgs(new LoacationMessage()
            {
                Date = msg.Date,
                Location = msg.Location,
                From = msg.From
            }));
        }

        protected virtual void OnOnContactMessageRecieved(Message msg)
        {
            OnContactMessageRecieved?.Invoke(this, new OnContactRecievedEventArgs(new ContactMessage()
            {
                Date = msg.Date,
                Contact = msg.Contact,
                From = msg.From
            }));
        }
    }
}