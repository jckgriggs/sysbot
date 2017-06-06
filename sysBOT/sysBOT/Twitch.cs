using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Events.Client;
using Newtonsoft.Json;

namespace sysBOT
{
    class Twitch
    {
        TwitchClient Client;
        public static string Channel;
        string Oauth;
        string Token;
        static CommandProcessor proc = new CommandProcessor();    
        public static string Username;
        Alerts alert = new Alerts();

        public Twitch(TwitchClient client, string channel, string oauth, string token, string username)
        {
            this.Client = client;
            Channel = channel;
            this.Oauth = oauth;
            this.Token = token;
            Username = username;
        }
        public Twitch()
        {

        }

        internal void userJoinedChannel(object sender, OnUserJoinedArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{e.Username} has joined");
            Console.ForegroundColor = ConsoleColor.White;
            Form1.invokeAlert($"{e.Username} has joined");
            alert.UserJoined(e.Username);
        }
        internal void chatCommandReceived(object sender, OnChatCommandReceivedArgs e)
        {
            Client.SendMessage(proc.Process(e.Command.Command));
        }

        internal void clientJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Client joined channel: {e.Channel}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void clientConnected(object sender, OnConnectedArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client connected to Twitch!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void clientConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Client could not connect; restart and contact dev if problem persists");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void incorrectLogin(object sender, OnIncorrectLoginArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Client could not connect due to an invalid login.\nPlease ensure all credentials are correct");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void newSubscriber(object sender, OnNewSubscriberArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{e.Subscriber.Name} has subscribed!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void userBanned(object sender, OnUserBannedArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{e.Username} has been banned for '{e.BanReason}'");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void userTimedout(object sender, OnUserTimedoutArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{e.Username} has been timed out for {e.TimeoutDuration} seconds because he {e.TimeoutReason}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void userLeftChannel(object sender, OnUserLeftArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{e.Username} has left");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void userResubscribed(object sender, OnReSubscriberArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{e.ReSubscriber.DisplayName} has been subscribed for {e.ReSubscriber.Months} months!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void moderatorLeft(object sender, OnModeratorLeftArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"[MOD] {e.Username} has left");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void moderatorJoined(object sender, OnModeratorJoinedArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[MOD] {e.Username} has joined");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void hostingStopped(object sender, OnHostingStoppedArgs e)
        {
            //TODO
        }

        internal void hostingStarted(object sender, OnHostingStartedArgs e)
        {
            //TODO
        }

        internal void clientDisconnected(object sender, OnDisconnectedArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Client has disconnected. Please restart or contact the dev if this problem persists.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal void setStreamTitle(string title)
        {
            TwitchApi.UpdateStreamTitle(title, Channel, this.Token);
            Form1.invokeAlert("Stream Title Updated");
        }
    }
}
