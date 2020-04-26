using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    public class LogInCommand : ICommand
    {
        LogInViewModel logInViewModel;

        public LogInCommand(LogInViewModel logInViewModel)
        {
            this.logInViewModel = logInViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return logInViewModel.CanLogIn;
        }

        public void Execute(object parameter)
        {
            logInViewModel.LogIn();
        }
    }
}
