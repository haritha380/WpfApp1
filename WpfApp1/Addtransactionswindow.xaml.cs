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
    /// Interaction logic for Addtransactionswindow.xaml
    /// </summary>
    public partial class Addtransactionswindow : Window
    {

        public List<string> categories = new List<string>();
        public Addtransactionswindow()
        {
            InitializeComponent();
            CategoryCombo.ItemsSource = App.db.Addcategory.ToList().Select(c=>c.name).ToList();
            foreach(string category in categories)
            {
                MessageBox.Show(category);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DashboardWindow().Show();
            Close();    
        }

        private void TransactionTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddTransactionButton_Click(object sender, RoutedEventArgs e)
        {
   
            var transaction = new Addtransactions()
            {
                type = (TransactionTypeCombo.SelectedItem as ComboBoxItem).Content.ToString(),
                amount = AmountBox.Text,
                category = CategoryCombo.SelectedItem.ToString()!,
                date = DateBox.Text,
                description = DescriptionBox.Text
            };
            App.db.Addtransactions.Add(transaction);
            App.db.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Window_Initialized_1(object sender, EventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Addcategorywindow().Show();
            Close();    
        }
    }
}
