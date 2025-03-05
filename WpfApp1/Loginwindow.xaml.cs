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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Loginwindow.xaml
    /// </summary>
    public partial class Loginwindow : Window
    {
        public Loginwindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var maching_users = App.db.Users.ToList().Where(user => user.Username == EmailBox.Text && user.Password == PasswordBox.Password);
            if (maching_users.Count() == 0)
            {
                MessageBox.Show("Email or Password not correct");
                return;
            }
            var user = maching_users.First();
            var category = new Addcategorywindow();
            category.Show();
            Close();

        }
    }
}
