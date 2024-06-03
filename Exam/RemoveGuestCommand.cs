using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam
{
    public class RemoveGuestCommand : ICommand
    {
        private ViewModel viewModel;

        public RemoveGuestCommand(ViewModel vm)
        {
            viewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is int guestId)
            {
                viewModel.RemoveGuestById(guestId);
            }
        }
    }

}
