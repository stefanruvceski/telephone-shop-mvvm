using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Client.View;
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
    public class LogInViewModel
    {
        #region Fields
        public Window Window { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        #endregion

        #region Constructor
        public LogInViewModel()
        {
            LogInCommand = new LogInCommand(this);
        }
        #endregion

        #region LogIn
        public ICommand LogInCommand
        {
            get;
            private set;
        }

        public bool CanLogIn
        {
            get
            {
                return !String.IsNullOrWhiteSpace(UserName) && !String.IsNullOrWhiteSpace(Password);
            }
        }

        public void LogIn()
        {
            try
            {
                Channel.Instance.logProxy.LogMessage(Enums.LOGTYPE.INFO, "Log In is clicked.");
                User user = Channel.Instance.userProxy.Get(UserName);
                if (user != null)
                {
                    if (user.Password == Password)
                    {
                        new MainWindow(user).Show();
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorect!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            ContentHandler.StartContent();
        }
        #endregion
    }
}
