using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CapGeminiTechTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<BasketItem> ItemsInBasket;

        public MainWindow()
        {
            InitializeComponent();
            SetupApp();
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void ScanItemCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                // Scan the item
                ScanItem(cboShopping.Text);
                // Set the total of all items scanned
                SetBasketTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SetupApp()
        {
            ItemsInBasket = new ObservableCollection<BasketItem>();
            lstBasket.DataContext = ItemsInBasket;
            cboShopping.Items.Add("Apple");
            cboShopping.Items.Add("Orange");
            cboShopping.SelectedIndex = 0;
            txtTotal.Text = "0.00";
        }

        private void ScanItem(string itemName)
        {
            BasketItem item = new BasketItem(itemName);
            ItemsInBasket.Add(item);
        }

        private void SetBasketTotal()
        {
            //IEnumerable<double> prices = ItemsInBasket.Select(p => p.ItemPrice);
            txtTotal.Text = ItemsInBasket.Select(p => p.ItemPrice).Sum().ToString("F");
        }
    }
}
