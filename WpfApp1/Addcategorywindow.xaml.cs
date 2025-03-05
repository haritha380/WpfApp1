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
    /// Interaction logic for Addcategorywindow.xaml
    /// </summary>
    public partial class Addcategorywindow : Window
    {
        public Addcategorywindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addcategory = new Addcategory()
            {
                type = type.Text,
                name = name.Text,

            };

            App.db.Addcategory.Add(addcategory!);
            App.db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var transactionwindow= new Addtransactionswindow();
            transactionwindow.Show();
            Close();
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
