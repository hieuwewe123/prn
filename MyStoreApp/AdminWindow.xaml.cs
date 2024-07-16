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
using System.Windows.Shapes;

namespace MyStoreApp
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
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

        private void ManageUsers_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(ManageUsersPanel);
        }

        private void ViewOrders_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(ViewOrdersPanel);
        }

        private void ManageProducts_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel(ManageProductsPanel);
        }

        private void ShowPanel(UIElement panelToShow)
        {
            ManageUsersPanel.Visibility = Visibility.Collapsed;
            ViewOrdersPanel.Visibility = Visibility.Collapsed;
            ManageProductsPanel.Visibility = Visibility.Collapsed;
            WelcomePanel.Visibility = Visibility.Collapsed;

            panelToShow.Visibility = Visibility.Visible;
        }
    }
}
