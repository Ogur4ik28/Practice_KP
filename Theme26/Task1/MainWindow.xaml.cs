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
using System.Xml.Linq;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string xmlFilePath = "students.xml";

        public MainWindow()
        {
            InitializeComponent();
            UpdateButtonStates();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var lastName = LastNameTextBox.Text;
            var firstName = FirstNameTextBox.Text;
            var birthDate = BirthDatePicker.SelectedDate?.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) || birthDate == null)
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var doc = XDocument.Load(xmlFilePath);
            var newStudent = new XElement("Студент",
                new XElement("Фамилия", lastName),
                new XElement("Имя", firstName),
                new XElement("ДатаРождения", birthDate));
            doc.Root.Add(newStudent);
            doc.Save(xmlFilePath);

            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
            BirthDatePicker.SelectedDate = null;

            MessageBox.Show("Студент добавлен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            DisplayStudents();
        }

        private void LoadXmlButton_Click(object sender, RoutedEventArgs e)
        {
            if (!System.IO.File.Exists(xmlFilePath))
            {
                MessageBox.Show("Файл XML не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DisplayStudents();
        }

        private void DisplayStudents()
        {
            var doc = XDocument.Load(xmlFilePath);
            OutputTextBlock.Text = string.Empty;

            foreach (var student in doc.Descendants("Студент"))
            {
                var lastName = student.Element("Фамилия")?.Value;
                var firstName = student.Element("Имя")?.Value;
                var birthDate = student.Element("ДатаРождения")?.Value;

                OutputTextBlock.Text += $"Фамилия: {lastName}, Имя: {firstName}, Дата Рождения: {birthDate}\n";
            }
        }

        private void UpdateButtonStates()
        {
            AddButton.IsEnabled = !string.IsNullOrWhiteSpace(xmlFilePath) && System.IO.File.Exists(xmlFilePath);
        }
    }
}
