using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class ChangeShopInfoCommand : ICommand
    {
        MainWindowViewModel mainWindowViewModel;

        public ChangeShopInfoCommand(MainWindowViewModel mainWindowViewModel)
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
            return mainWindowViewModel.CanManageShop;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.ChangeShop();
        }
    }
}
