using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class AddThisShopCommand : ICommand
    {

        private AddNewShopViewModel addNewShopViewModel;

        public AddThisShopCommand(AddNewShopViewModel addNewShopViewModel)
        {
            this.addNewShopViewModel = addNewShopViewModel;
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
            return addNewShopViewModel.CanAddShop;
        }

        public void Execute(object parameter)
        {
            addNewShopViewModel.AddShop();
        }

    }
}
