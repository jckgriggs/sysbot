using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    class Program
    {
        static List<User> userList = new List<User>();
        static string userJson;
        static void Main(string[] args)
        {
            jsonAdd(1, "jack");
            jsonAdd(2, "systemctl");
            jsonAdd(3, "sys_BOT");
            Console.ReadLine();
        }
        static void jsonStart(int id, string username)
        {
        }
        static void jsonAdd(int id, string username)
        {
            User user = new User();
            user.id = id;
            user.username = username;
            userList.Add(user);
            userJson = JsonConvert.SerializeObject(userList, Formatting.None);
            Console.WriteLine(userJson);
        }
    }
}
