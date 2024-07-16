using Microsoft.Data.SqlClient;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string connectionString = "Server=LAPTOP-TI0IJH5T\\SQLEXPRESS;Database=StoreDB;User Id=sa;Password=123456;Encrypt=False;TrustServerCertificate=True"; // Update with your connection string
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            var userRole = AuthenticateUser(email, password);
            if (userRole != null)
            {
                MessageBox.Show("Login successful!");

                if (userRole == "Admin")
                {
                    AdminWindow adminWindow = new AdminWindow(); // Replace with your actual admin window class
                    adminWindow.Show();
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(); // Replace with your main window class
                    mainWindow.Show();
                }

                this.Close(); // Close the login window
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private string AuthenticateUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MemberRole FROM AccountMember WHERE EmailAddress = @Email AND MemberPassword = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password); // Consider hashing the password in production

                    var result = command.ExecuteScalar();
                    return result?.ToString(); // Return the role if found
                }
            }
        }
    }
}
