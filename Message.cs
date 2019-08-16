using System.Threading;
using Telegram.Bot.Args;

namespace boardgame_bot
{
    public class Message
    {
        internal static async void Players(MessageEventArgs e)
        {
            Thread.Sleep(1000);
            await Bot.botClient.SendTextMessageAsync(
              chatId: e.Message.Chat,
              text: "How many people are going to play?");
        }
        internal static async void Start(MessageEventArgs e)
        {
            Thread.Sleep(1000);
            await Bot.botClient.SendTextMessageAsync(
              chatId: e.Message.Chat,
              text: "Press /start to begin");
        }

        internal static async void RecommendMonopoly(MessageEventArgs e)
        {
            Thread.Sleep(1000);
            await Bot.botClient.SendTextMessageAsync(
              chatId: e.Message.Chat,
              text: "You should play Monopoly!");
        }
    }
}