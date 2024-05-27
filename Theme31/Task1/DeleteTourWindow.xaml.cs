using System.Windows;

namespace Task1
{
    public partial class RemoveTouristWindow : Window
    {
        public int TourID { get; private set; }

        public RemoveTouristWindow()
        {
            InitializeComponent();
        }

        private void ConfirmDeletionButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка корректности введенного кода тура
            if (int.TryParse(tourCodeTextBox.Text, out int parsedID))
            {
                TourID = parsedID;
                DialogResult = true;
            }
            else
            {
                // Сообщение об ошибке в случае некорректного ввода
                MessageBox.Show("Введите действительный код тура.");
            }
        }

        private void AbortButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
