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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyBrowser
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

       

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri("https://www.google.com");
            Urlbox.Text = "www.google.com";

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(@"http://" + Urlbox.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Browser.GoBack();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
                    
        }

        private void Fwdbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Browser.GoForward();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}