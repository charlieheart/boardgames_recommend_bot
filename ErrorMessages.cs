using System;
using System.Threading;
using Telegram.Bot.Args;

namespace boardgame_bot
{
    internal static class ErrorMessages
    {
        internal static async void NotANumber(MessageEventArgs e)
        {
            Thread.Sleep(1000);
            await Bot.botClient.SendTextMessageAsync(
              chatId: e.Message.Chat,
              text: "Please enter a number");
        }

        internal static async void Zero(string v, MessageEventArgs e)
        {
            Thread.Sleep(1000);
            await Bot.botClient.SendTextMessageAsync(
              chatId: e.Message.Chat,
              text: $"{v} cannot be zero");
        }
    }
}