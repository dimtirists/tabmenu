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

namespace TabMenu
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var products = GetProducts();
            //if(products.Count > 0)
            //{
            //    ProductsList.ItemsSource = products;   
            //}
        }

        //private List<Product> GetProducts()
        //{
        //    return new List<Product>()
        //    {
        //        new Product("Nike", "Air Jordan", 12),
        //        new Product("Adidas", "Go Throug", 22),
        //        new Product("Puma", "Angry", 33)

        //    };
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch(index)
            {
                case 0:
                    GridMain.Background = Brushes.Aquamarine;
                    break;
                case 1:
                    GridMain.Background = Brushes.Beige;
                    break;
                case 2:
                    GridMain.Background = Brushes.CadetBlue;
                    break;
                case 3:
                    GridMain.Background = Brushes.DarkBlue;
                    break;
                case 4:
                    GridMain.Background = Brushes.Firebrick;
                    break;
                case 5:
                    GridMain.Background = Brushes.Gainsboro;
                    break;
                case 6:
                    GridMain.Background = Brushes.HotPink;
                    break;
            }
        }

        private void MoveButton(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MyAccountButton(object sender, RoutedEventArgs e)
        {

        }

        private void OrderButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void ContactClickButton(object sender, RoutedEventArgs e)
        {

        }

        private void FAQButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
