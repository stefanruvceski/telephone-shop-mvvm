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
    class ChangeThisTelephoneCommand : IMyCommand
    {
        private ChangeTelephoneInfoViewModel changeTelephoneInfoViewModel;

        public ChangeThisTelephoneCommand(ChangeTelephoneInfoViewModel changeTelephoneInfoViewModel)
        {
            this.changeTelephoneInfoViewModel = changeTelephoneInfoViewModel;
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
            return changeTelephoneInfoViewModel.CanChangeTelephone;
        }

        public void Execute(object parameter)
        {
            changeTelephoneInfoViewModel.ExecuteChangeTelephone();
        }

        public void MyExecute(object parameter)
        {
            changeTelephoneInfoViewModel.ExecuteChangeTelephone(parameter);
        }

        public void MyUnexecute(object parameter)
        {
            changeTelephoneInfoViewModel.UnexecuteChangeTelephone(parameter);
        }
    }
}
