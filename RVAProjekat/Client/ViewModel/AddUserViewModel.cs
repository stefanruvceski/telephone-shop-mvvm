using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static Common.Model.Enums;

namespace Client.ViewModel
{
    public class AddUserViewModel : INotifyPropertyChanged
    {
        #region Fields
        LogHandler logHandler;
        private bool admin = false;

        public Window Window { get; set; }
        public User NewUser { get; set; } 
        public bool Admin
        {
            get{return admin;}
            set{admin = value;}
        }
        #endregion

        #region Constructor
        public AddUserViewModel()
        {
            logHandler = LogHandler.Instance;
            NewUser = new User();
            AddUserCommand = new AddThisUserCommand(this);
        }
        #endregion

        #region Add User
        public ICommand AddUserCommand
        {
            get;
            private set;
        }

        public bool CanAddUser
        {
            get
            {
                return !String.IsNullOrWhiteSpace(NewUser.Name) && !String.IsNullOrWhiteSpace(NewUser.LastName) && !String.IsNullOrWhiteSpace(NewUser.Password) && !String.IsNullOrWhiteSpace(NewUser.Username);
            }

        }

        public void AddUser()
        {
            Channel.Instance.logProxy.LogMessage(Enums.LOGTYPE.INFO, "Add new user is clicked.");

            //Strategy pattern for validation of user
            Context context = new Context(NewUser);
            if (context.ChackValidation())
            {
                try
                {
                    if (!Admin)
                        NewUser.Type = TYPE.USER;
                    else
                        NewUser.Type = TYPE.ADMIN;
                    if (Channel.Instance.userProxy.Add(NewUser))
                    {
                        MessageBox.Show("Successfully added user " + NewUser.Name);
                        logHandler.LogManagerLogging(LOGTYPE.INFO, "Successfully added user " + NewUser.Name);
                        Window.Close();

                    }
                    else
                    {
                        MessageBox.Show("Username \"" + NewUser.Username + "\" already exists, try another one..");
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

        #region INotify member
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
