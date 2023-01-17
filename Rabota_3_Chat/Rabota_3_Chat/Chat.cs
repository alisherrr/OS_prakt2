using System;
using NLog;
using System.Configuration;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Rabota_3_Chat
{
    public class GetMessageEventArgs : EventArgs
    {
        public string User { set; get; }
        public string Message { set; get; }
    }

    public class Chat
    {
        public event EventHandler<GetMessageEventArgs> GetMessage;
        UdpClient udpClient = new UdpClient();

        // Для получение данных с файла конфигурации App.config
        Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        // Для ведения логов (NLog)
        private static Logger logger = LogManager.GetCurrentClassLogger();
        //Для отмены задач
        CancellationTokenSource cancelTokenSource;
        CancellationToken token;


        // Получение сообщений
        public async void RecieveMessages()
        {
            IPEndPoint endPoint;

            // Читаем данные с файла конфигурации
            try
            {
                if (config.AppSettings.Settings["IP_Recieve"].Value != "" && config.AppSettings.Settings["Port"].Value != "")
                    endPoint = new IPEndPoint(IPAddress.Parse(config.AppSettings.Settings["IP_Recieve"].Value),
                        Convert.ToInt32(config.AppSettings.Settings["Port"].Value));
                else
                    endPoint = new IPEndPoint(IPAddress.Any, 3000);
            }
            catch (Exception e)
            {
                logger.Error(e);
                endPoint = new IPEndPoint(IPAddress.Any, 3000);
            }

            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udpClient.Client.Bind(endPoint);
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            while (true)
            {
                try
                {
                    var result = await udpClient.ReceiveAsync(token);
                    var recieve_message = Encoding.UTF8.GetString(result.Buffer);
                    int index = recieve_message.IndexOf(" ");
                    string user = "", message = "";
                    for (int i = 0; i < recieve_message.Length; i++)
                    {
                        if (i < index)
                            user += recieve_message[i];
                        if (i > index)
                            message += recieve_message[i];
                    }
                    GetMessage?.Invoke(this, new GetMessageEventArgs { User = user, Message = message });
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    logger.Error(e);
                    Environment.Exit(1);
                }
            }
        }

        // Отправка сообщения
        public void SendMessage(string message, string user)
        {
            string sendMessage = user + " " + message;
            IPEndPoint endPoint;

            try
            {
                if (config.AppSettings.Settings["IP_Send"].Value == "" && config.AppSettings.Settings["Port"].Value == "")
                    endPoint = new IPEndPoint(IPAddress.Any, 3000);
                else
                    endPoint = new IPEndPoint(IPAddress.Parse(config.AppSettings.Settings["IP_Send"].Value),
                        Convert.ToInt32(config.AppSettings.Settings["Port"].Value));
            }
            catch (Exception e)
            {
                logger.Error(e);
                endPoint = new IPEndPoint(IPAddress.Any, 3000);
            }

            endPoint = new IPEndPoint(IPAddress.Broadcast, 3000);
            byte[] data = Encoding.UTF8.GetBytes(sendMessage);
            udpClient.SendAsync(data, endPoint);
        }

        // Закрытие соединения
        public void CloseConnection()
        {
            if (cancelTokenSource != null)
                cancelTokenSource.Cancel(false);
            udpClient.Close();
        }
    }
}
