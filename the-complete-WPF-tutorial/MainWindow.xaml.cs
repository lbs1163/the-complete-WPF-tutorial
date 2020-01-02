using System;
using System.Windows;
using System.Windows.Controls;

namespace the_complete_WPF_tutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }
    }
}