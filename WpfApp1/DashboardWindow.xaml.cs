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
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            Update();

        }
        public void Update()
        {
            dataframe.ItemsSource = App.db.Addtransactions.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var sel = dataframe.SelectedItem as Addtransactions;
            if (sel != null) {
                App.db.Addtransactions.Remove(App.db.Addtransactions.First(t=>t.Id == sel.Id));
                App.db.SaveChanges();
                Update();   
            }
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();    
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Addtransactionswindow().Show();
            Close();
        }
    }
}
