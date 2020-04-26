using Client.Adition;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class DeleteTelephoneCommand : IMyCommand
    {
        MainWindowViewModel mainWindowViewModel;

        public DeleteTelephoneCommand(MainWindowViewModel mainWindowViewModel)
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
            return (mainWindowViewModel.TypeOfUser && mainWindowViewModel.CanManageTelephone);
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.ExecuteDeleteTelephone();
        }

        public void MyExecute(object parameter)
        {
            mainWindowViewModel.ExecuteDeleteTelephone(parameter);
        }

        public void MyUnexecute(object parameter)
        {
            mainWindowViewModel.UnexecuteDeleteTelephone(parameter);
        }
    }
}
