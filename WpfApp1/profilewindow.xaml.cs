﻿using System;
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
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for profilewindow.xaml
    /// </summary>
    public partial class profilewindow : Window
    {
        public profilewindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var Profile = new profile()
            //{
            //    username = .Text,
            //    email = email.Text,

            //};


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Profile = new profile()
            {
                newpassword = newpassword.Text,
                

            };

            App.db.profile.Add(Profile!);
            App.db.SaveChanges();
        }

        private void newpassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
