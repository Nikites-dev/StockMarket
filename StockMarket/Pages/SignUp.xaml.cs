using System.Globalization;
using System.Windows;
using System;
using System.Windows.Controls;
using StockMarket.Models;
using StockMarket.MongoDB;
using System.Windows.Navigation;

namespace StockMarket.Pages
{
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
        }

        String birthDate = "";

        private void btnSignIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignIn());
        }

        private void btnSignUp_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(isValidation())
            {

                if(MongoDBAction.FindByLogin(EdLogin.Text) == null)
                {
                    User user = new User();

                    user.FName = EdFname.Text;
                    user.LName = EdLname.Text;
                    user.Balance = 10000;
                    user.Password = EdPassword.Password;
                    user.Login = EdLogin.Text;
                    user.DateBirth = birthDate;

                    MongoDBAction.AddToDatabase(user);

                    NavigationService.Navigate(new SignIn(EdLogin.Text));

                } else
                {
                    MessageBox.Show("пользователь с таким логином уже существует!");
                }
            }
        }


        public bool isValidation()
        {
            if(EdFname.Text != "" && EdLname.Text != "" && birthDate != "" && EdPassword.Password != "" && EdLogin.Text != "") 
            {
                if(EdPassword.Password == EdConfirmPassword.Password)
                {
                 return true;
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return false;
                }
                
            } else
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
        }

        private void EdBirth_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = EdBirth.SelectedDate;

            birthDate = selectedDate.Value.Date.ToShortDateString();

            
        }
    }
}