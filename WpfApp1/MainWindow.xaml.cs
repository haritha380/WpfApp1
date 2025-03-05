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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new User()
            {
                Email = EmailBox.Text,
                Password = PasswordBox.Text,
                Username = Usernamebox.Text
            };

            App.db.Users.Add(user!);
            App.db.SaveChanges();
            MessageBox.Show("Sign Up Successful!");
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = new Loginwindow();
            login.Show();
            Close();
        }
    }
}