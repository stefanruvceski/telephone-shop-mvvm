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
    public class BuyTelephoneCommand : IMyCommand
    {
        MainWindowViewModel mainWindowViewModel;

        public BuyTelephoneCommand(MainWindowViewModel mainWindowViewModel)
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
            mainWindowViewModel.ExecuteBuyTelephone();
        }

        public void MyExecute(object parameter)
        {
            mainWindowViewModel.ExecuteBuyTelephone(parameter);
        }

        public void MyUnexecute(object parameter)
        {
            mainWindowViewModel.UnexecuteBuyTelephone(parameter);
        }
    }
}
