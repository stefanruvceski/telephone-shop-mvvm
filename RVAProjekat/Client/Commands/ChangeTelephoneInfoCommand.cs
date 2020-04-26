using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class ChangeTelephoneInfoCommand : ICommand
    {
        MainWindowViewModel mainWindowViewModel;

        public ChangeTelephoneInfoCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
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
            return mainWindowViewModel.CanManageTelephone;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.ChangeTelephone();
        }
    }
}
