using Microsoft.Win32;
using StockMarket.MongoDB;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace StockMarket.Pages
{
    /// <summary>
    /// Interaction logic for Admition.xaml
    /// </summary>
    public partial class Admition : Page
    {
        public byte[] ImageBin { get; set; }

        public Admition()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {


            LoadImage();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (EdName.Text != "" && EdPrice.Text != "" && ImageBin != null)
            {
                FileSystemService.UploadImageToDbAsync(ImageBin, EdName.Text);

                Item item = new Item();
                item.Name = EdName.Text;
                item.Price = int.Parse(EdPrice.Text);
                item.Image = ImageBin;
                
                MongoDBAction.AddItemToDB(item);
                
                MessageBox.Show("Succses!");

                EdName.Text = "";
                EdPrice.Text = "";
            }
        }


        private async Task LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != null)
            {
                ImageBin = File.ReadAllBytes(openFileDialog.FileName);

                string fileName = openFileDialog.FileName;
                image.Source = new BitmapImage(new Uri(fileName));
               
            }
        }
        
        private void GetImageFromBd(String ImageName)
        {
            image.Source = LoadImage(FileSystemService.DownImageToDbAsync(ImageName));

        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
