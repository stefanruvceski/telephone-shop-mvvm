using Common.Model;
using Common.ServerContracts;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Server
{
    public class ServerLogger : ILogger
    {
        #region Fields
        private static ServerLogger instance;
        private static log4net.ILog log;

        //Singleton
        public static ServerLogger Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServerLogger();
                return instance;
            }
        }
        #endregion

        ServerLogger()
        {
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        
        public bool LogMessage(LOGTYPE logType, String message)
        {
            try
            {
                switch (logType)
                {
                    case LOGTYPE.DEBUG:
                        log.Debug("SERVER side - " + message);
                        break;
                    case LOGTYPE.INFO:
                        log.Info("SERVER side - " + message);
                        break;
                    case LOGTYPE.WARN:
                        log.Warn("SERVER side - " + message);
                        break;
                    case LOGTYPE.ERROR:
                        log.Error("SERVER side - " + message);
                        break;
                    case LOGTYPE.FATAL:
                        log.Fatal("SERVER side - " + message);
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
