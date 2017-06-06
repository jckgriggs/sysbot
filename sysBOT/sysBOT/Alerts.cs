using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysBOT
{
    class Alerts
    {
        List<User> userList = new List<User>();
        int id;
        bool userExists;
        string userJson;

        internal void UserJoined(string username)
        {
            User user = new User();
            id++;
            user.id = this.id;
            user.username = username;

            foreach (User User in userList)
            {
                if (User.username == user.username)
                {
                    userExists = true;
                    break;
                }
                else
                {
                    userExists = false;
                }
            }

            if (!userExists)
            {
                userList.Add(user);
                userJson = JsonConvert.SerializeObject(userList, Formatting.None);
                if (Connection.sessionAlive)
                {
                    switch (Connection.setJson(Twitch.Username, userJson))
                    {
                        case 1:
                            Console.WriteLine($"user json set to {userJson}");
                            break;
                        case 2:
                            Console.WriteLine($"user json could not be set");
                            break;
                        case 3:
                            Console.WriteLine("alerts not logged in");
                            break;
                        case 4:
                            Console.WriteLine("unknown error");
                            break;
                        default:
                            Console.WriteLine("even more unknown error");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("user already accounted for");
                }
            }
        }
    }
}

