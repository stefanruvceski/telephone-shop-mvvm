using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    class ChangeProfilInfoCommand : ICommand
    {
        private ProfilInformationViewModel profilInformationViewModel;

        public ChangeProfilInfoCommand(ProfilInformationViewModel profilInformationViewModel)
        {
            this.profilInformationViewModel = profilInformationViewModel;
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
            return profilInformationViewModel.IsPossible;
        }

        public void Execute(object parameter)
        {
            profilInformationViewModel.Change();
        }
    }
}
