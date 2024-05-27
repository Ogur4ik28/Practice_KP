using System.Data;
using System.Windows;
using System.Data.SQLite;

namespace TravelAgencyApp
{
    public partial class MainWindow : Window
    {
        private readonly string dbConnection = @"DataSource=../../../Database/DBTur_firm.db;Version=3;";

        public MainWindow()
        {
            InitializeComponent();
            DisplayAllTourists();
        }

        private void OnSelectAllToursClick(object sender, RoutedEventArgs e)
        {
            DisplayAllTours();
        }

        private void DisplayAllTours()
        {
            using (SQLiteConnection connection = new(dbConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Туры";
                SQLiteDataAdapter adapter = new(query, connection);
                DataTable toursTable = new();
                adapter.Fill(toursTable);
                dataGridTours.ItemsSource = toursTable.DefaultView;
            }
        }

        private void DisplayAllTourists()
        {
            using (SQLiteConnection connection = new(dbConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Туристы";
                SQLiteDataAdapter adapter = new(query, connection);
                DataTable touristsTable = new();
                adapter.Fill(touristsTable);
                dataGridTourists.ItemsSource = touristsTable.DefaultView;
            }
        }

        private void OnDeleteTourClick(object sender, RoutedEventArgs e)
        {
            DeleteTouristWindow deleteWindow = new();
            if (deleteWindow.ShowDialog() == true)
            {
                int tourId = deleteWindow.TourCode;
                using (SQLiteConnection connection = new(dbConnection))
                {
                    connection.Open();
                    string query = "DELETE FROM Туры WHERE Код_тура = @Код_тура";
                    SQLiteCommand command = new(query, connection);
                    command.Parameters.AddWithValue("@Код_тура", tourId);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Тур удален." : "Тур с таким кодом не найден.");
                }
                DisplayAllTours();
            }
        }

        private void OnAddTouristClick(object sender, RoutedEventArgs e)
        {
            AddTouristWindow addWindow = new();
            if (addWindow.ShowDialog() == true)
            {
                string firstName = addWindow.Name;
                string lastName = addWindow.Surname;
                string middleName = addWindow.MiddleName;

                using (SQLiteConnection connection = new(dbConnection))
                {
                    connection.Open();
                    string query = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@Фамилия, @Имя, @Отчество)";
                    SQLiteCommand command = new(query, connection);
                    command.Parameters.AddWithValue("@Фамилия", lastName);
                    command.Parameters.AddWithValue("@Имя", firstName);
                    command.Parameters.AddWithValue("@Отчество", middleName);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Турист добавлен.");
                DisplayAllTourists();
            }
        }

        private void OnUpdateTouristClick(object sender, RoutedEventArgs e)
        {
            UpdateTouristWindow updateWindow = new();
            if (updateWindow.ShowDialog() == true)
            {
                int touristId = updateWindow.TouristCode;
                string firstName = updateWindow.Name;
                string lastName = updateWindow.Surname;
                string middleName = updateWindow.MiddleName;

                using (SQLiteConnection connection = new(dbConnection))
                {
                    connection.Open();
                    string query = "UPDATE Туристы SET Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество WHERE Код_туриста = @Код_туриста";
                    SQLiteCommand command = new(query, connection);
                    command.Parameters.AddWithValue("@Код_туриста", touristId);
                    command.Parameters.AddWithValue("@Фамилия", lastName);
                    command.Parameters.AddWithValue("@Имя", firstName);
                    command.Parameters.AddWithValue("@Отчество", middleName);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Турист обновлен." : "Турист с таким кодом не найден.");
                }
                DisplayAllTourists();
            }
        }
    }
}
