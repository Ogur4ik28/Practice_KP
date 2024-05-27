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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonEnter.Click += ButtonEnter_Click;
            buttonAbout.Click += ButtonAbout_Click;
            buttonClose.Click += ButtonClose_Click;
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName.Text) || string.IsNullOrWhiteSpace(textBoxEnterName.Text))
            {
                input = "World!";
            }
            else
            {
                input = textBoxEnterName.Text;
            }

            textBlockHello.Text = hello + " " + input;
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
            AboutApp about = new AboutApp(info);
            about.ShowDialog();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}