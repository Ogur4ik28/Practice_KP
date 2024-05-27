using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private HelpProvider helpProvider;
        private Button helpButton;
        private ToolTip toolTip;

        public Form4()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
            HelpButton = true;

            helpProvider = new HelpProvider();
            helpProvider.HelpNamespace = @"D:\Practic\Tema24\WinFormsApp3\bin\Debug\net8.0-windows\helpfortask4.txt";

            // Ñîçäàéòå êíîïêó äëÿ âûçîâà ñïðàâêè
            helpButton = new Button();
            helpButton.Text = "Help";
            helpButton.Click += new EventHandler(HelpButton_Click);
            this.Controls.Add(helpButton);

            helpProvider.SetHelpString(Name, "Ââåäèòå âàøå èìÿ");
            helpProvider.SetHelpString(Surname, "Ââåäèòå âàøó ôàìèëèþ");
            helpProvider.SetHelpString(MiddleName, "Ââåäèòå âàøå îò÷åñòâî");
            helpProvider.SetHelpString(Email, "Ââåäèòå âàø àäðåñ ýëåêòðîííîé ïî÷òû");
            helpProvider.SetHelpString(PhoneNumber, "Ââåäèòå âàø íîìåð òåëåôîíà");
            helpProvider.SetHelpString(LocationCity, "Âûáåðèòå âàø ãîðîä ïðîæèâàíèÿ");
            helpProvider.SetHelpString(CallOperator, "Âûáåðèòå âàøåãî îïåðàòîðà ñâÿçè");
            helpProvider.SetHelpString(Male, "Âûáåðèòå âàø ïîë");
            helpProvider.SetHelpString(Female, "Âûáåðèòå âàø ïîë");
            helpProvider.SetHelpString(NotWorking, "Âûáåðèòå âàø îïûò ðàáîòû");
            helpProvider.SetHelpString(LessThanOneYear, "Âûáåðèòå âàø îïûò ðàáîòû");
            helpProvider.SetHelpString(FromOneToFiveYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            helpProvider.SetHelpString(FromFiveToNineYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            helpProvider.SetHelpString(MoreThanTenYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            helpProvider.SetHelpString(DriverCategoryA, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            helpProvider.SetHelpString(DriverCategoryB, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            helpProvider.SetHelpString(DriverCategoryC, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            helpProvider.SetHelpString(DriverCategoryD, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            helpProvider.SetHelpString(FullTime, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            helpProvider.SetHelpString(PartTime, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            helpProvider.SetHelpString(WorkAtHome, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            helpProvider.SetHelpString(TimeWork, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            helpProvider.SetHelpString(MinSalary, "Ââåäèòå ìèíèìàëüíóþ çàðïëàòó");
            helpProvider.SetHelpString(MaxSalary, "Ââåäèòå ìàêñèìàëüíóþ çàðïëàòó");


            toolTip = new ToolTip();
            toolTip.SetToolTip(Name, "Ââåäèòå âàøå èìÿ");
            toolTip.SetToolTip(Surname, "Ââåäèòå âàøó ôàìèëèþ");
            toolTip.SetToolTip(MiddleName, "Ââåäèòå âàøå îò÷åñòâî");
            toolTip.SetToolTip(Email, "Ââåäèòå âàø àäðåñ ýëåêòðîííîé ïî÷òû");
            toolTip.SetToolTip(PhoneNumber, "Ââåäèòå âàø íîìåð òåëåôîíà");
            toolTip.SetToolTip(LocationCity, "Âûáåðèòå âàø ãîðîä ïðîæèâàíèÿ");
            toolTip.SetToolTip(CallOperator, "Âûáåðèòå âàøåãî îïåðàòîðà ñâÿçè");
            toolTip.SetToolTip(Male, "Âûáåðèòå âàø ïîë");
            toolTip.SetToolTip(Female, "Âûáåðèòå âàø ïîë");
            toolTip.SetToolTip(NotWorking, "Âûáåðèòå âàø îïûò ðàáîòû");
            toolTip.SetToolTip(LessThanOneYear, "Âûáåðèòå âàø îïûò ðàáîòû");
            toolTip.SetToolTip(FromOneToFiveYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            toolTip.SetToolTip(FromFiveToNineYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            toolTip.SetToolTip(MoreThanTenYears, "Âûáåðèòå âàø îïûò ðàáîòû");
            toolTip.SetToolTip(DriverCategoryA, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            toolTip.SetToolTip(DriverCategoryB, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            toolTip.SetToolTip(DriverCategoryC, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            toolTip.SetToolTip(DriverCategoryD, "Âûáåðèòå êàòåãîðèè âîäèòåëüñêèõ ïðàâ");
            toolTip.SetToolTip(FullTime, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            toolTip.SetToolTip(PartTime, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            toolTip.SetToolTip(WorkAtHome, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            toolTip.SetToolTip(TimeWork, "Âûáåðèòå âàø ãðàôèê ðàáîòû");
            toolTip.SetToolTip(MinSalary, "Ââåäèòå ìèíèìàëüíóþ çàðïëàòó");
            toolTip.SetToolTip(MaxSalary, "Ââåäèòå ìàêñèìàëüíóþ çàðïëàòó");
        }

        // Îáðàáîò÷èê ñîáûòèÿ íàæàòèÿ íà êíîïêó ñïðàâêè
        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            string GetSelectedRadioButtonText(RadioButton[] radioButtons)
            {
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton.Text;
                    }
                }
                return "";
            }

            string GetSelectedCheckBoxText(CheckBox[] checkBoxes)
            {
                string result = "";
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        result += checkBox.Text;
                    }
                }
                return result;
            }

            string[] textBoxValues = textBoxes.Select(textBox => textBox.Text).ToArray();

            string[] comboBoxValues = comboBoxes.Select(comboBox => comboBox.Text).ToArray();

            string sex = GetSelectedRadioButtonText(radioButtons);
            string dateOfBirth = DateBirth.Text;

            string workExp = GetSelectedRadioButtonText(workExpRadioButtons);
            if (workExp == "")
            {
                MessageBox.Show("Íå âûáðàí îïûò ðàáîòû");
                return;
            }

            string driveCategory = GetSelectedCheckBoxText(categoryCheckboxes);

            string workGraphic = GetSelectedRadioButtonText(workGraphicRadioButtons);
            if (workGraphic == "")
            {
                MessageBox.Show("Âûáåðèòå ãðàôèê ðàáîòû");
                return;
            }

            string salaryFrom = Convert.ToString(MinSalary.Value);
            string salaryTo = Convert.ToString(MaxSalary.Value);

            AboutMe.AppendText($"Ôàìèëèÿ: {textBoxValues[1]}\n");
            AboutMe.AppendText($"Èìÿ: {textBoxValues[0]}\n");
            AboutMe.AppendText($"Îò÷åñòâî: {textBoxValues[2]}\n");
            AboutMe.AppendText($"Ïîë: {sex}\n");
            AboutMe.AppendText($"Äàòà ðîæäåíèÿ: {dateOfBirth}\n");
            AboutMe.AppendText($"Ãîðîä ïðîæèâàíèÿ: {comboBoxValues[0]}\n");
            AboutMe.AppendText($"Ýëåêòðîííàÿ ïî÷òà: {textBoxValues[3]}\n");
            AboutMe.AppendText($"Òåëåôîí: {textBoxValues[4]}\n");
            AboutMe.AppendText($"Îïåðàòîð ñâÿçè: {comboBoxValues[1]}\n");
            AboutMe.AppendText($"Îïûò ðàáîòû: {workExp}\n");
            AboutMe.AppendText($"Ëè÷íûé àâòîìîáèëü: {(HaveAPersonalCar.Checked ? "Äà" : "Íåò")}\n");
            AboutMe.AppendText($"Âîäèòåëüñêîå óäîñòîâåðåíèå: {(DriverLicense.Checked ? "Äà" : "Íåò")}\n");
            AboutMe.AppendText($"Êàòåãîðèè âîäèòåëüñêèõ ïðàâ: {driveCategory}\n");
            AboutMe.AppendText($"Çàðïëàòà îò: {salaryFrom}\n");
            AboutMe.AppendText($"Çàðïëàòà äî: {salaryTo}\n");
            AboutMe.AppendText($"Ãðàôèê ðàáîòû: {workGraphic}\n");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in categoryCheckboxes)
            {
                checkBox.Checked = false;
            }

            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }

            AboutMe.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
