using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    static class ClientDirectory
    {
        private static string Authorization_path = @"AuthorizationSave\authorization.txt";

        public static bool LocalAuthorization()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"AuthorizationSave");
            if(!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            try
            {
                using (StreamReader sr = new StreamReader(Authorization_path, Encoding.UTF8))
                {
                    if ((ClientLogic.Username = sr.ReadLine()) != null)
                    {
                        ClientLogic.Email = sr.ReadLine();
                        ClientLogic.Password = sr.ReadLine();
                    }
                    else
                        return false;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void SaveAuthorization()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Authorization_path, true, Encoding.UTF8))
                {
                    sw.WriteLine(ClientLogic.Username);
                    sw.WriteLine(ClientLogic.Email);
                    sw.WriteLine(ClientLogic.Password);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с методом: SaveAuthorization();");
            }
        }
    }
}
