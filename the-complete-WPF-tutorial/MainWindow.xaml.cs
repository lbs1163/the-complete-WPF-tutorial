using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace the_complete_WPF_tutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}