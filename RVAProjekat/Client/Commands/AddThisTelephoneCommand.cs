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
    class AddThisTelephoneCommand : IMyCommand
    {
        private AddNewTelephoneViewModel addNewTelephoneViewModel;


        public AddThisTelephoneCommand()
        {

        }
        public AddThisTelephoneCommand(AddNewTelephoneViewModel addNewTelephoneViewModel)
        {
            this.addNewTelephoneViewModel = addNewTelephoneViewModel;
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
            return addNewTelephoneViewModel.CanAddTelephone;
        }

        public void Execute(object parameter)
        {
            addNewTelephoneViewModel.ExecuteAddTelephone();
        }

        public void MyExecute(object parameter)
        {
            addNewTelephoneViewModel.ExecuteAddTelephone();
        }

        public void MyUnexecute(object parameter)
        {
            addNewTelephoneViewModel.UnxecuteAddTelephone(parameter);
        }
    }
}
