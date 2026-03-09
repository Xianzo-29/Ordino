using Ordino.Model;
using Ordino.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ordino.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        public UserModel CurrentUser { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel() 
        {
            CurrentUser = new UserModel();
            LoginCommand = new RelayCommand(ExecuteLogin);
        }

        private void ExecuteLogin(object? parameter)
        {
            if (CurrentUser.UserName.Trim() == "admin" && CurrentUser.Password.Trim() == "1234")
            {
                var loginWindow = new View.MainWindow();
                loginWindow.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}