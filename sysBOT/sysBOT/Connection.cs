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
        static Twitch twitch;

        public Connection(string username, string oauth, string channel)
        {
            client = new TwitchLib.TwitchClient(new TwitchLib.Models.Client.ConnectionCredentials(username, oauth), channel, '!', '!', true);
            twitch = new Twitch(client); //Pass on client info to API handler

            //BEGIN: API Calls
            client.OnConnected += twitch.clientConnected;
            client.OnJoinedChannel += twitch.clientJoinedChannel;
            client.OnChatCommandReceived += twitch.chatCommandReceived;
            client.OnUserJoined += twitch.userJoinedChannel;
            client.OnConnectionError += twitch.clientConnectionError;
            client.OnDisconnected += twitch.clientDisconnected;
            client.OnHostingStarted += twitch.hostingStarted;
            client.OnHostingStopped += twitch.hostingStopped;
            client.OnIncorrectLogin += twitch.incorrectLogin;
            client.OnModeratorJoined += twitch.moderatorJoined;
            client.OnModeratorLeft += twitch.moderatorLeft;
            client.OnNewSubscriber += twitch.newSubscriber;
            client.OnReSubscriber += twitch.userResubscribed;
            client.OnUserBanned += twitch.userBanned;
            client.OnUserLeft += twitch.userLeftChannel;
            client.OnUserTimedout += twitch.userTimedout;
            //END: API Calls

            client.Connect();
        }
    }
}
