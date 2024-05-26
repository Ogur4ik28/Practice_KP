using System;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += ButtonRun_Click;
            buttonAbout.Click += ButtonAbout_Click;
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
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
            textBlockHello.Text = $"{hello} {input}";
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"о программме {this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }
    }
}
