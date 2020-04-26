using Client.ClientServerChannel;
using Client.ViewModel;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Client.Adition
{
    public class LogHandler
    {
        #region Fields
        private MainWindowViewModel mainWindowViewModel;
        private static LogHandler instance;

        //Singleton sa viewmodel-om poljem za koriscenje liste logova
        public static LogHandler Instance
        {
            get
            {
                if (instance == null)
                    instance = new LogHandler();
                return instance;
            }
        }

        public MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return mainWindowViewModel;
            }
            set
            {
                if(mainWindowViewModel == null)
                {
                    mainWindowViewModel = value;
                }
            }
        }
        #endregion

        #region Operation
        public void LogManagerLogging(LOGTYPE type, String text)
        {
            Channel.Instance.logProxy.LogMessage(type, text);
            mainWindowViewModel.Logging.Add(new ClientLog() { Type = type.ToString(), Text = text });
        }
        #endregion
    }
}
