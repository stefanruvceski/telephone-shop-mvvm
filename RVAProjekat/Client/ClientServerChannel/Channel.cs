using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client.ClientServerChannel
{
    class Channel
    {
        #region Fields
        public IUserServer userProxy;
        public IShopServer shopProxy;
        public ITelephoneServer telephoneProxy;
        public ILogger logProxy;

        private static Channel instance;

        //Singleton
        public static Channel Instance
        {
            get
            {
                if (instance == null)
                    instance = new Channel();
                return instance;
            }

        }
        #endregion

        #region Constructor
        public Channel()
        {
            ChannelFactory<IUserServer> channelFactoryUser = new ChannelFactory<IUserServer>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:4000/IUserServer"));
            userProxy = channelFactoryUser.CreateChannel();

            ChannelFactory<IShopServer> channelFactoryShop = new ChannelFactory<IShopServer>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:4000/IShopServer"));
            shopProxy = channelFactoryShop.CreateChannel();

            ChannelFactory<ITelephoneServer> channelFactoryTelephone = new ChannelFactory<ITelephoneServer>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:4000/ITelephoneServer"));
            telephoneProxy = channelFactoryTelephone.CreateChannel();

            ChannelFactory<ILogger> channelFactoryLogger = new ChannelFactory<ILogger>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:4000/ILogger"));
            logProxy = channelFactoryLogger.CreateChannel();
        }
        #endregion
    }
}
