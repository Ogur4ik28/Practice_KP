using System.Windows;

namespace TravelAgencyApp
{
    public partial class RemoveTouristWindow : Window
    {
        public int SelectedTourCode { get; private set; }

        public RemoveTouristWindow()
        {
            InitializeComponent();
        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tourCodeTextBox.Text, out int tourId))
            {
                SelectedTourCode = tourId;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Введите корректный код тура.");
            }
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
