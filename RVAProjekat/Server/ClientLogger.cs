using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Server
{
    public class ClientLogger : ILogger
    {
        #region Fields
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public bool LogMessage(LOGTYPE logType, String message)
        {
            try
            {
                switch (logType)
                {
                    case LOGTYPE.DEBUG:
                        log.Debug("CLIENT side - " + message);
                        break;
                    case LOGTYPE.INFO:
                        log.Info("CLIENT side - " + message);
                        break;
                    case LOGTYPE.WARN:
                        log.Warn("CLIENT side - " + message);
                        break;
                    case LOGTYPE.ERROR:
                        log.Error("CLIENT side - " + message);
                        break;
                    case LOGTYPE.FATAL:
                        log.Fatal("CLIENT side - " + message);
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
