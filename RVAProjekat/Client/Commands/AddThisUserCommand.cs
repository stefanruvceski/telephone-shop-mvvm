using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    public class AddThisUserCommand : ICommand
    {
        AddUserViewModel addUserViewModel;

        public AddThisUserCommand(AddUserViewModel addUserViewModel)
        {
            this.addUserViewModel = addUserViewModel;
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
            return addUserViewModel.CanAddUser;
        }

        public void Execute(object parameter)
        {
            addUserViewModel.AddUser();
        }
    }
}
