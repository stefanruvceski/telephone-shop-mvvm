using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class RedoCommand : ICommand
    {
        private MainWindowViewModel mainWindowViewModel;

        public RedoCommand(MainWindowViewModel mainWindowViewModel)
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
            return mainWindowViewModel.CanRedo;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.Redo();
        }
    }
}
