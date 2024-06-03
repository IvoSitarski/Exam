using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Exam.Models;

namespace Exam
{


    using System;
    using System.Windows;
    using System.Windows.Input;

    public class AddRequestCommand : ICommand
    {
        private ViewModel viewModel;

        public AddRequestCommand(ViewModel vm)
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
            try
            {
                viewModel.Request.Guests.Add(new Guest() { GuestName = "Иван Иванов", GuestAge = 20 });
                viewModel.Request.Guests.Add(new Guest() { GuestName = "Мария Петрова", GuestAge = 22 });
                viewModel.Request.Guests.Add(new Guest() { GuestName = "Георги Георгиев", GuestAge = 25});

                viewModel.SaveRequestToDatabase(viewModel.Request);
                viewModel.ApproveRequest(viewModel.Request);

                MessageBox.Show("Заявката беше успешно записана и одобрена.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                GuestsWindow guestsWindow = new GuestsWindow
                {
                    DataContext = viewModel
                };
                guestsWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при добавяне на гост: {ex.Message}\n{ex.InnerException?.Message}", "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }




}
