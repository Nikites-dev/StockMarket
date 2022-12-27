using System.Windows;
using System.Windows.Controls;
using StockMarket.Models;

namespace StockMarket.Pages
{
    public partial class Person : Page
    {
        private User user = new User();
        
        public Person()
        {
            InitializeComponent();
        }

        public Person(User user)
        {
            InitializeComponent();
            this.user = user;

            TxtCount.Text = user.listPurchasedItems.Count.ToString();
            TxtBalance.Text = user.Balance.ToString();
            TxtAmount.Text = CalculateAmount().ToString();
            listTemplate.ItemsSource = user.listPurchasedItems;
        }
        
        private void ListTemplate_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("ОТличная покупка!");
        }
        
        
        public int CalculateAmount()
        {
            int amount = 0;
            foreach (var item in user.listPurchasedItems)
            {
                amount += item.Price;
            }
            return amount;
        }


        private void BtnCatalog_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Catalog(user));
        }

        private void BtnBusket_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket(user));
        }

        private void BtnLogOut_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignIn());
        }
    }
}