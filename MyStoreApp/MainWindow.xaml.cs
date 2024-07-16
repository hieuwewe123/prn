using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ViewProducts_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(ProductsPanel);
        }

        private void ViewCart_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(CartPanel);
        }

        private void ViewOrders_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(OrdersPanel);
        }

        private void ShowPanel(UIElement panelToShow)
        {
            ProductsPanel.Visibility = Visibility.Collapsed;
            CartPanel.Visibility = Visibility.Collapsed;
            OrdersPanel.Visibility = Visibility.Collapsed;
            WelcomePanel.Visibility = Visibility.Collapsed;

            panelToShow.Visibility = Visibility.Visible;
        }
    }
}