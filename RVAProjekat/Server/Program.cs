using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(String[] args)
        {
            #region Color
            Console.ForegroundColor = ConsoleColor.Green;
            #endregion

            #region Initial Data
            new InitialData();
            ServerSideService serverSideService = new ServerSideService();
            #endregion

            #region Database
            String path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf("bin"));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            #endregion

            #region WCF Connection
            serverSideService.Open();
            Console.ReadKey();

            serverSideService.Close();
            Console.ReadKey();
            #endregion
        }
    }
}
