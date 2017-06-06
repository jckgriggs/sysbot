using TwitchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using TwitchLib.Events.Client;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Web;

namespace sysBOT
{
    public class Connection
    {
        static TwitchClient client;
        static Twitch twitch;
        static CookieContainer cookieContainer = new CookieContainer();
        static string response;
        public static bool sessionAlive;

        public Connection(string username, string oauth, string channel, string token)
        {
            Console.WriteLine($"Connection Channel: {channel}");
            client = new TwitchLib.TwitchClient(new TwitchLib.Models.Client.ConnectionCredentials(username, oauth), channel, '!', '!', true);
            twitch = new Twitch(client, channel, oauth, token, username); //Pass on client info to API handler
            TwitchApi.SetAccessToken(token);
            TwitchApi.SetClientId("29gmfry8w4deaxesx55owtfna8x4pj");

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

            switch(alertRegister(username, sha256_hash(username)))
            {
                case 1:
                    signInSwitch:
                    switch(alertSignIn(username, sha256_hash(username)))
                    {
                        case 1:
                            sessionAlive = true;
                            Console.WriteLine("Registered and signed into sysAlerts");
                            break;
                        case 2:
                            sessionAlive = false;
                            Console.WriteLine("Could not sign into sysAlerts");
                            break;
                        case 3:
                            Console.WriteLine("Webserver connection failed. sysBOT shutting down...");
                            Console.ReadLine();
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("problem with sign in");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Failed to register with alerts system");
                    break;
                case 3:
                    goto signInSwitch;
                default:
                    Console.WriteLine($"Something went wrong; {username}; {sha256_hash(username)}");
                    break;
            }

            client.Connect();
        }
        int alertSignIn(string user, string token)
        {
            response = Request(new Uri($"https://jackgriggs.net/sysbot/alert/signin.php?user={user}&token={token}"));
            if (response.Contains("success"))
            {
                return 1; //Signed in
            }
            else if (response.Contains("failed"))
            {
                return 2; //Failed to sign in

            }
            else if (response.Contains("connfail"))
            {
                return 3;
            }
            else
            {
                return 0; //Unknown error
            }
        }
            int alertRegister(string user, string token)
        {
            response = Request(new Uri($"https://jackgriggs.net/sysbot/alert/register.php?user={user}&token={token}"));
            if (response.Contains("success"))
            {
                return 1; //User registered
            }
            else if (response.Contains("failed"))
            {
                return 2; //User could not register

            }
            else if (response.Contains("username take"))
            {
                return 3; //User account already created; sign in
            }
            else
            {
                return 0; //Unknown error
            }
        }
        public static int setJson(string user, string json)
        {
            response = Request(new Uri($"https://jackgriggs.net/sysbot/alert/setjson.php?user={user}&json={json}"));
            if (response.Contains("success"))
            {
                return 1; //JSON set
            }
            else if (response.Contains("failed"))
            {
                return 2; //JSON not set

            }
            else if (response.Contains("not logged in"))
            {
                return 3; //Not logged in
            }
            else
            {
                return 0; //Unknown error
            }
        }
        static string Request(Uri uri)
        {
            try {
                Uri.EscapeUriString(uri.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "GET";
                request.CookieContainer = cookieContainer;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }catch(Exception e)
            {
                //return e.ToString();
                return "connfail";
            }
        }

        public static String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Join("", hash.ComputeHash(Encoding.UTF8.GetBytes(value)).Select(item => item.ToString("x2")));
            }
        }
    }
}
