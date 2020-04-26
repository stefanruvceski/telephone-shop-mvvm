using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class ProfilInformationViewModel
    {
        #region Fields
        LogHandler logHandler;

        public Window Window { get; set; }
        public User CurrentUser { get; set; }
        #endregion

        #region Constructor
        public ProfilInformationViewModel(User user, Window w)
        {
            logHandler = LogHandler.Instance;
            CurrentUser = user;
            Window = w;
            ChangeProfilInfoCommand = new ChangeProfilInfoCommand(this);
        }
        #endregion

        #region Change Profil Information
        public ICommand ChangeProfilInfoCommand
        {
            get;
            private set;
        }

        public bool IsPossible
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(CurrentUser.Name) && !String.IsNullOrWhiteSpace(CurrentUser.LastName))
                    return true;
                else
                    return false;
            }
        }

        public void Change()
        {
            Context context = new Context(CurrentUser);
            if (context.ChackValidation())
            {
                try
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Change Information is clicked.");
                    if (Channel.Instance.userProxy.Update(CurrentUser))
                    {
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falied");
                    }
                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                    MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please, fiil all fields!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            ContentHandler.Refresh();
        }
        #endregion
    }
}
