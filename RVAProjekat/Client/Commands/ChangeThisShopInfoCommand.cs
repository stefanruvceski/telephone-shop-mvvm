using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class ChangeThisShopInfoCommand : ICommand
    {
        private ChangeShopInfoViewModel changeShopInfoViewModel;

        public ChangeThisShopInfoCommand(ChangeShopInfoViewModel changeShopInfoViewModel)
        {
            this.changeShopInfoViewModel = changeShopInfoViewModel;
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
            return changeShopInfoViewModel.CanChange;
        }

        public void Execute(object parameter)
        {
            changeShopInfoViewModel.ChangeShop();
        }
    }
}
