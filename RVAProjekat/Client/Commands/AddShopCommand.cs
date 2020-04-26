using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class AddShopCommand : ICommand
    {
        private MainWindowViewModel mainWindowViewModel;

        public AddShopCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true ;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.AddShop();
        }
    }
}
