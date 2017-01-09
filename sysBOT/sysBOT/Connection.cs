using TwitchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using TwitchLib.Events.Client;

namespace sysBOT
{
    public class Connection
    {
        static TwitchClient client;
        static CommandProcessor proc = new CommandProcessor();
        static Connection()
        {
            client = new TwitchLib.TwitchClient(new TwitchLib.Models.Client.ConnectionCredentials(ConfigurationManager.AppSettings.Get("botUsername"), ConfigurationManager.AppSettings.Get("botOauth")), ConfigurationManager.AppSettings.Get("channel"), '!', '!', true);

            client.OnConnected += clientConnected;
            client.OnJoinedChannel += clientJoinedChannel;
            client.OnChatCommandReceived += chatCommandReceived;
            client.OnUserJoined += userJoinedChannel;
            client.Connect();
        }

        private static void userJoinedChannel(object sender, OnUserJoinedArgs e)
        {
            Console.WriteLine($"{e.Username} has joined");
        }

        private static void chatCommandReceived(object sender, OnChatCommandReceivedArgs e)
        {
            client.SendMessage(proc.Process(e.Command.Command));
        }

        private static void clientJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            Console.WriteLine($"Client joined channel: {e.Channel}");
        }

        private static void clientConnected(object sender, OnConnectedArgs e)
        {
            Console.WriteLine("Client connected to Twitch!");
        }
    }
}
