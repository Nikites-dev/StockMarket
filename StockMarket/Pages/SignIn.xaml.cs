using StockMarket.Models;
using StockMarket.MongoDB;
using System.Windows;
using System.Windows.Controls;

namespace StockMarket.Pages
{
    public partial class SignIn : Page
    {
        private User user = new User();
        public SignIn()
        {
            InitializeComponent();
        }

        public SignIn(string login)
        {
            InitializeComponent();
            EdLogin.Text = login;
        }

        private void btnSignUp_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUp());
        }

        private void btnSignIn_Click(object sender, object e)
        {
            if(EdLogin.Text == "admin" && EdPassword.Password == "admin")
            {
                NavigationService.Navigate(new Admition());
            }else
            {
                if (isValidation())
                {
                    NavigationService.Navigate(new Catalog(user));
                }
            }
        }

        public bool isValidation()
        {
            if (EdPassword.Password != "" && EdLogin.Text != "")
            {
                var userLog = MongoDBAction.FindByLogin(EdLogin.Text);
                if (userLog != null)
                {
                    if (userLog.Password != EdPassword.Password)
                    {
                        MessageBox.Show("Неправильный пароль!");
                    }

                    if(userLog.Login == EdLogin.Text && userLog.Password == EdPassword.Password)
                    {
                        user = userLog;
                        return true;
                    }
                    return false;

                } else
                {
                    MessageBox.Show("неверный логин или пароль!");
                    return false;
                }

          
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
        }
    }
}