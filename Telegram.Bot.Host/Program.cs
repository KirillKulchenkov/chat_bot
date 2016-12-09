using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Domain.Client;

namespace Telegram.Bot.Host
{
    class Program
    {
        static TelegramBot _bot;
        static void Main(string[] args)
        {
            _bot = new TelegramBot("283050671:AAG1qB5XJ0GKx5S5Jh6tZfJO_rGmytHjvaU");
            _bot.Start();
            _bot.OnLocationMessageRecieved += BotOnOnLocationMessageRecieved;
            _bot.OnPhotoMessageRecieved +=BotOnOnPhotoMessageRecieved;
            _bot.OnTextMessageRecieved += BotOnOnTextMessageRecieved;
            _bot.OnContactMessageRecieved +=BotOnOnContactMessageRecieved;
            Console.ReadKey();
        }

        private static void BotOnOnContactMessageRecieved(object sender, OnContactRecievedEventArgs onContactRecievedEventArgs)
        {
            return;
            
        }

        private static void BotOnOnTextMessageRecieved(object sender, OnTextRecievedEventArgs onTextRecievedEventArgs)
        {
            return;
        }

        private static void BotOnOnPhotoMessageRecieved(object sender, OnPhotoRecievedEventArgs onPhotoRecievedEventArgs)
        {
            
            return;
        }

        private static void BotOnOnLocationMessageRecieved(object sender, OnLocationRecievedEventArgs onLocationRecievedEventArgs)
        {
            return;
        }

        
    }
}
