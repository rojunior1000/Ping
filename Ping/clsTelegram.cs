using System;

using Telegram.Bot;
using Telegram.Bot.Args;

namespace MonitoramentoIPs
{

    public class clsTelegram
    {
        static ITelegramBotClient botClient;

        public clsTelegram()
        {
            botClient = new TelegramBotClient("902134727:AAFCnXMP0incgDbhK5Lxb3ik_86gyeRDqPA");
        }

        public bool verificarAcessoInternet()
        {
            try
            {
                var me = botClient.GetMeAsync().Result;
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public async void Bot_SendMessage(string pesan)
        {
            await botClient.SendTextMessageAsync(
              chatId: "-1001175678988", //bot Criado no telegram parametro (LogsSys)
              text: pesan
            );
        }

    }
}
