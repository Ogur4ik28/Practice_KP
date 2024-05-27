using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> contactsList = new List<Contact>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var lastName = LastNameTextBox.Text;
            var birthDate = BirthDatePicker.SelectedDate;
            var phoneNumber = PhoneNumberTextBox.Text;

            if (IsValidInput(lastName, birthDate, phoneNumber))
            {
                var contact = new Contact
                {
                    LastName = lastName,
                    BirthDate = birthDate.Value,
                    PhoneNumber = phoneNumber
                };

                contactsList.Add(contact);
                SaveContactToXml(contact);
                RefreshOutput();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }

        private bool IsValidInput(string lastName, DateTime? birthDate, string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(lastName) && birthDate.HasValue && !string.IsNullOrWhiteSpace(phoneNumber);
        }

        private void SaveContactToXml(Contact contact)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = System.IO.Path.Combine(documentsPath, "Notebook.xml");

            var contactElement = new XElement("Contact",
                new XElement("LastName", contact.LastName),
                new XElement("BirthDate", contact.BirthDate.ToString("yyyy-MM-dd")),
                new XElement("PhoneNumber", contact.PhoneNumber)
            );

            XDocument xDocument;
            if (System.IO.File.Exists(filePath))
            {
                xDocument = XDocument.Load(filePath);
                xDocument.Root.Add(contactElement);
            }
            else
            {
                xDocument = new XDocument(new XElement("Notebook", contactElement));
            }

            xDocument.Save(filePath);
            MessageBox.Show("Контакт успешно сохранен.");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RefreshOutput();
        }

        private void RefreshOutput()
        {
            OutputStackPanel.Children.Clear();

            if (TextBoxRadioButton.IsChecked == true)
            {
                DisplayContactsInTextBox();
            }
            else if (TreeViewRadioButton.IsChecked == true)
            {
                DisplayContactsInTreeView();
            }
            else if (ListBoxRadioButton.IsChecked == true)
            {
                DisplayContactsInListBox();
            }
        }

        private void DisplayContactsInTextBox()
        {
            var textBox = new TextBox
            {
                Text = string.Join(Environment.NewLine, contactsList),
                IsReadOnly = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Height = 150,
                Width = 560
            };
            OutputStackPanel.Children.Add(textBox);
        }

        private void DisplayContactsInTreeView()
        {
            var treeView = new TreeView
            {
                Height = 150,
                Width = 560
            };
            foreach (var contact in contactsList)
            {
                var item = new TreeViewItem
                {
                    Header = contact.LastName
                };
                item.Items.Add($"Дата рождения: {contact.BirthDate:yyyy-MM-dd}");
                item.Items.Add($"Номер телефона: {contact.PhoneNumber}");
                treeView.Items.Add(item);
            }
            OutputStackPanel.Children.Add(treeView);
        }

        private void DisplayContactsInListBox()
        {
            var listBox = new ListBox
            {
                Height = 150,
                Width = 560
            };
            foreach (var contact in contactsList)
            {
                listBox.Items.Add($"{contact.LastName}, {contact.BirthDate:yyyy-MM-dd}, {contact.PhoneNumber}");
            }
            OutputStackPanel.Children.Add(listBox);
        }
    }

    public class Contact
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {BirthDate:yyyy-MM-dd}, {PhoneNumber}";
        }
    }
}
