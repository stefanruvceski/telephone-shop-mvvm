using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerSideService
    {
        #region Fields
        
        private static ServiceHost UserServiceHost;
        private static ServiceHost ShopServiceHost;
        private static ServiceHost TelephoneServiceHost;
        private static ServiceHost LogServiceHost;

        #endregion
        public ServerSideService()
        {
            UserServiceHost = new ServiceHost(typeof(UserServer));
            UserServiceHost.AddServiceEndpoint(typeof(IUserServer), new NetTcpBinding(), new Uri("net.tcp://localhost:4000/IUserServer"));

            ShopServiceHost = new ServiceHost(typeof(ShopServer));
            ShopServiceHost.AddServiceEndpoint(typeof(IShopServer), new NetTcpBinding(), new Uri("net.tcp://localhost:4000/IShopServer"));

            TelephoneServiceHost = new ServiceHost(typeof(TelephoneServer));
            TelephoneServiceHost.AddServiceEndpoint(typeof(ITelephoneServer), new NetTcpBinding(), new Uri("net.tcp://localhost:4000/ITelephoneServer"));

            LogServiceHost = new ServiceHost(typeof(ClientLogger));
            LogServiceHost.AddServiceEndpoint(typeof(ILogger), new NetTcpBinding(), new Uri("net.tcp://localhost:4000/ILogger"));


        }

        public void Open()
        {
            UserServiceHost.Open();
            ShopServiceHost.Open();
            TelephoneServiceHost.Open();
            LogServiceHost.Open();
            Console.WriteLine("Service hosts are opened at " + DateTime.Now);
        }

        public void Close()
        {
            UserServiceHost.Close();
            ShopServiceHost.Close();
            TelephoneServiceHost.Close();
            LogServiceHost.Close();
            Console.WriteLine("Service hosts are closed at " + DateTime.Now);
        }
    }
}
