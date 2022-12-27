using System;
using System.Windows;
using System.Windows.Controls;
using StockMarket.Models;
using StockMarket.MongoDB;

namespace StockMarket.Pages
{
    public partial class Basket : Page
    {
        private User user = new User();
        public Item itemChoose; 
        
        public Basket()
        {
            InitializeComponent();
        }
        
        public Basket(User user)
        {
            InitializeComponent();
            this.user = user;

            TxtCount.Text = user.listBasket.Count.ToString();
            TxtBalance.Text = user.Balance.ToString();
            TxtAmount.Text = CalculateAmount().ToString();
            listTemplate.ItemsSource = user.listBasket;
        }

        private void ListTemplate_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item item = listTemplate.SelectedItem as Item;
            itemChoose = item;
        }

        private void btnBuy_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (user.Balance > CalculateAmount())
            {
                user.Balance -= CalculateAmount();
                int itemCnt = user.listBasket.Count;

                for (int i = 0; i < itemCnt; i++)
                {
                 user.listPurchasedItems.Add(user.listBasket[i]);   
                }
                
                user.listBasket.Clear();
                
                TxtCount.Text = user.listBasket.Count.ToString();
                TxtBalance.Text = user.Balance.ToString();
                TxtAmount.Text = CalculateAmount().ToString();
                listTemplate.ItemsSource = null;
                MongoDBAction.UpdateByLogin(user.Login, user);
            }
            else
            {
                MessageBox.Show("Нехватает денег!");
            }
            
        }

        public int CalculateAmount()
        {
            int amount = 0;
            foreach (var item in user.listBasket)
            {
                amount += item.Price;
            }
            return amount;
        }  

        private void btnCatalog_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Catalog(user));
        }

        private void btnPerson_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Person(user));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (itemChoose != null)
            {
                user.listBasket.Remove(itemChoose);
                listTemplate.ItemsSource = null;
                listTemplate.ItemsSource = user.listBasket;
                MongoDBAction.UpdateByLogin(user.Login, user);
            }
            
        }
    }
}