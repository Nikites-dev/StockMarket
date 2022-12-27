using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StockMarket.Models;
using StockMarket.MongoDB;

namespace StockMarket.Pages
{
    public partial class Catalog : Page
    {
        private User user = new User();
        public Catalog()
        {
            InitializeComponent();

            listTemplate.ItemsSource = MongoDBAction.GetListItem(MongoDBAction.GetListItemNames());
            StackBasket.Visibility = Visibility.Hidden;
        }
        
        public Catalog(User user)
        {
            InitializeComponent();
            this.user = user; 
            TxtCount.Text = user.listBasket.Count.ToString();
            listTemplate.ItemsSource = MongoDBAction.GetListItem(MongoDBAction.GetListItemNames());
            StackBasket.Visibility = Visibility.Visible;
        }

        private void listTemplate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item item = listTemplate.SelectedItem as Item;

            if (user != null)
            {
                user.listBasket.Add(item);
                TxtCount.Text = user.listBasket.Count.ToString();
                MongoDBAction.UpdateByLogin(user.Login, user);
            }
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket(user));
        }
    }
}
