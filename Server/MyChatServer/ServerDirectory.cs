using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatServer
{
    class ServerDirectory
    {
        static public string Database_catalog = @"DataBase";
        static public string Users_catalog = @"Users";
        static public string Database_path = @"DataBase\database.txt";
        static public string Chats_catalog = @"Chats";

        public static void CreateDirectory()
        {
            DirectoryInfo DataBase = new DirectoryInfo(Database_catalog);
            if (!DataBase.Exists)
            {
                DataBase.Create();
                Console.WriteLine("Server create Database_catalog.");
            }

            DirectoryInfo Users = new DirectoryInfo(Users_catalog);
            if (!Users.Exists)
            {
                Users.Create();
                Console.WriteLine("Server create Users_catalog.");
            }

            DirectoryInfo Chats = new DirectoryInfo(Chats_catalog);
            if (!Chats.Exists)
            {
                Chats.Create();
                Console.WriteLine("Server create Chats_catalog.");
            }
        }
        public static void CreatePersonalCatalog(string username, string email, string password)
        {
            string catalogPath = @"Users\" + username;
            DirectoryInfo userCatalog = new DirectoryInfo(catalogPath);
            if(!userCatalog.Exists)
            {
                userCatalog.Create();
                Console.WriteLine($"Catalog create. User: {username}");
            }

            string filePath = catalogPath + @"\" + username + @".txt";

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                sw.WriteLine(username);
                sw.WriteLine(email);
                sw.WriteLine(password);
                sw.Close();
                sw.Dispose();
            }
        }
        public static bool NewFriend(string myUsername, string friendUsername)
        {
            string myPath = @"Users\" + myUsername + @"\" + myUsername + @".txt";
            string friendPath = @"Users\" + friendUsername + @"\" + friendUsername + @".txt";
            string line;
            bool newFriend = true;
            using (StreamReader sr = new StreamReader(myPath, Encoding.UTF8))
            {
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == friendUsername)
                    {
                        newFriend = false;
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            if(newFriend)
            {
                string chatId = Guid.NewGuid().ToString();
                using (StreamWriter sw = new StreamWriter(myPath, true, Encoding.UTF8))
                {
                    sw.WriteLine(friendUsername);
                    sw.WriteLine(chatId);
                    sw.Close();
                    sw.Dispose();
                }
                using (StreamWriter sw = new StreamWriter(friendPath, true, Encoding.UTF8))
                {
                    sw.WriteLine(myUsername);
                    sw.WriteLine(chatId);
                    sw.Close();
                    sw.Dispose();
                }
            }
            return newFriend;
        }
        public static bool ExistUser(string username)
        {
            string line;
            using (StreamReader sr = new StreamReader(Database_path, Encoding.UTF8))
            {
                
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == username)
                        return true;
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                }
                sr.Close();
                sr.Dispose();
            }

            return false;
        }
        public static string FindChat(string myUsername, string friendUsername)
        {
            string myPath = @"Users\" + myUsername + @"\" + myUsername + @".txt";
            string line;
            using (StreamReader sr = new StreamReader(myPath, Encoding.UTF8))
            {
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == friendUsername)
                    {
                        line = sr.ReadLine();
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }

            string chatPath = @"Chats\" + line + @".txt";
            string chat = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(chatPath, Encoding.UTF8))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        chat += line + '\r' + '\n';
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"There is no chat along this path yet: {chatPath} . Chat: {myUsername}");
            }
            return chat;
        }
        public static void SaveMessage(string myUsername, string friendUsername, string message)
        {
            string myPath = @"Users\" + myUsername + @"\" + myUsername + @".txt";
            string line;
            using (StreamReader sr = new StreamReader(myPath, Encoding.UTF8))
            {
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == friendUsername)
                    {
                        line = sr.ReadLine();
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }

            string chatPath = @"Chats\" + line + @".txt";
            using (StreamWriter sw = new StreamWriter(chatPath, true, Encoding.UTF8))
            {
                sw.WriteLine(message);
                sw.Close();
                sw.Dispose();
            }
        }
        public static List<string> FriendList(string username)
        {
            string myPath = @"Users\" + username + @"\" + username + @".txt";
            string line;
            List<string> temp = new List<string>();
            using (StreamReader sr = new StreamReader(myPath, Encoding.UTF8))
            {
                line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    temp.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                sr.Dispose();
            }
            return temp;
        }
    }
}
