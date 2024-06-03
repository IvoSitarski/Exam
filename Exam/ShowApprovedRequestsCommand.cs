using Exam;
using System.Windows.Input;

public class ShowApprovedRequestsCommand : ICommand
{
    private ViewModel viewModel;

    public ShowApprovedRequestsCommand(ViewModel vm)
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
        ApprovedRequestsWindow window = new ApprovedRequestsWindow
        {
            DataContext = viewModel
        };
        window.Show();
    }
}

