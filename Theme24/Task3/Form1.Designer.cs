using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SurnameLabel = new Label();
            NameLabel = new Label();
            MiddleNameLabel = new Label();
            Surname = new TextBox();
            Name = new TextBox();
            MiddleName = new TextBox();
            Sex = new GroupBox();
            Female = new RadioButton();
            Male = new RadioButton();
            BirthDateGroupBox = new GroupBox();
            DateBirth = new DateTimePicker();
            LocationLabel = new Label();
            EMailLabel = new Label();
            Email = new TextBox();
            LocationCity = new ComboBox();
            phoneLabel = new Label();
            CallOperator = new ComboBox();
            PhoneNumber = new TextBox();
            WorkExperience = new GroupBox();
            FromFiveToNineYears = new RadioButton();
            LessThanOneYear = new RadioButton();
            MoreThanTenYears = new RadioButton();
            FromOneToFiveYears = new RadioButton();
            NotWorking = new RadioButton();
            OtherInfo = new GroupBox();
            DriverCategoryD = new CheckBox();
            DriverCategoryC = new CheckBox();
            DriverCategoryB = new CheckBox();
            DriverCategoryA = new CheckBox();
            DriverCategory = new Label();
            DriverLicense = new CheckBox();
            HaveAPersonalCar = new CheckBox();
            SalaryRange = new GroupBox();
            ToLabel = new Label();
            FromLabel = new Label();
            MaxSalary = new NumericUpDown();
            MinSalary = new NumericUpDown();
            TimeToWork = new GroupBox();
            TimeWork = new RadioButton();
            WorkAtHome = new RadioButton();
            PartTime = new RadioButton();
            FullTime = new RadioButton();
            AboutMe = new RichTextBox();
            AboutMeLabel = new Label();
            SaveData = new Button();
            ClearForm = new Button();
            CancelForm = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Sex.SuspendLayout();
            BirthDateGroupBox.SuspendLayout();
            WorkExperience.SuspendLayout();
            OtherInfo.SuspendLayout();
            SalaryRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinSalary).BeginInit();
            TimeToWork.SuspendLayout();
            SuspendLayout();
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(22, 20);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(76, 20);
            SurnameLabel.TabIndex = 0;
            SurnameLabel.Text = "Фамилия:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(55, 56);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Имя:";
            // 
            // MiddleNameLabel
            // 
            MiddleNameLabel.AutoSize = true;
            MiddleNameLabel.Location = new Point(23, 89);
            MiddleNameLabel.Name = "MiddleNameLabel";
            MiddleNameLabel.Size = new Size(75, 20);
            MiddleNameLabel.TabIndex = 2;
            MiddleNameLabel.Text = "Отчество:";
            // 
            // Surname
            // 
            Surname.Location = new Point(104, 17);
            Surname.Name = "Surname";
            Surname.Size = new Size(260, 27);
            Surname.TabIndex = 3;
            // 
            // Name
            // 
            Name.Location = new Point(103, 53);
            Name.Name = "Name";
            Name.Size = new Size(261, 27);
            Name.TabIndex = 4;
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(103, 86);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(261, 27);
            MiddleName.TabIndex = 5;
            // 
            // Sex
            // 
            Sex.Controls.Add(Female);
            Sex.Controls.Add(Male);
            Sex.Location = new Point(383, 20);
            Sex.Name = "Sex";
            Sex.Size = new Size(131, 81);
            Sex.TabIndex = 6;
            Sex.TabStop = false;
            Sex.Text = "Пол:";
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(15, 53);
            Female.Name = "Female";
            Female.Size = new Size(92, 24);
            Female.TabIndex = 1;
            Female.TabStop = true;
            Female.Text = "Женский";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(15, 25);
            Male.Name = "Male";
            Male.Size = new Size(93, 24);
            Male.TabIndex = 0;
            Male.TabStop = true;
            Male.Text = "Мужской";
            Male.UseVisualStyleBackColor = true;
            // 
            // BirthDateGroupBox
            // 
            BirthDateGroupBox.Controls.Add(DateBirth);
            BirthDateGroupBox.Location = new Point(551, 17);
            BirthDateGroupBox.Name = "BirthDateGroupBox";
            BirthDateGroupBox.Size = new Size(222, 84);
            BirthDateGroupBox.TabIndex = 7;
            BirthDateGroupBox.TabStop = false;
            BirthDateGroupBox.Text = "Дата Рождения:";
            // 
            // DateBirth
            // 
            DateBirth.Location = new Point(15, 32);
            DateBirth.Name = "DateBirth";
            DateBirth.Size = new Size(190, 27);
            DateBirth.TabIndex = 0;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(23, 146);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(151, 20);
            LocationLabel.TabIndex = 8;
            LocationLabel.Text = "Город проживания: ";
            // 
            // EMailLabel
            // 
            EMailLabel.AutoSize = true;
            EMailLabel.Location = new Point(23, 181);
            EMailLabel.Name = "EMailLabel";
            EMailLabel.Size = new Size(150, 20);
            EMailLabel.TabIndex = 9;
            EMailLabel.Text = "Электронная почта: ";
            // 
            // Email
            // 
            Email.Location = new Point(181, 180);
            Email.Name = "Email";
            Email.Size = new Size(575, 27);
            Email.TabIndex = 10;
            // 
            // LocationCity
            // 
            LocationCity.FormattingEnabled = true;
            LocationCity.Items.AddRange(new object[] { "Брест", "Витебск", "Гомель", "Гродно", "Минск", "Могилёв" });
            LocationCity.Location = new Point(181, 143);
            LocationCity.Name = "LocationCity";
            LocationCity.Size = new Size(575, 28);
            LocationCity.TabIndex = 11;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(23, 219);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(134, 20);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Номер телефона: ";
            // 
            // CallOperator
            // 
            CallOperator.FormattingEnabled = true;
            CallOperator.Items.AddRange(new object[] { "A1", "MTC", "Life :)" });
            CallOperator.Location = new Point(181, 216);
            CallOperator.Name = "CallOperator";
            CallOperator.Size = new Size(107, 28);
            CallOperator.TabIndex = 13;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(307, 217);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(449, 27);
            PhoneNumber.TabIndex = 14;
            // 
            // WorkExperience
            // 
            WorkExperience.Controls.Add(FromFiveToNineYears);
            WorkExperience.Controls.Add(LessThanOneYear);
            WorkExperience.Controls.Add(MoreThanTenYears);
            WorkExperience.Controls.Add(FromOneToFiveYears);
            WorkExperience.Controls.Add(NotWorking);
            WorkExperience.Location = new Point(23, 268);
            WorkExperience.Name = "WorkExperience";
            WorkExperience.Size = new Size(750, 125);
            WorkExperience.TabIndex = 15;
            WorkExperience.TabStop = false;
            WorkExperience.Text = "Опыт Работы:";
            // 
            // FromFiveToNineYears
            // 
            FromFiveToNineYears.AutoSize = true;
            FromFiveToNineYears.Location = new Point(298, 66);
            FromFiveToNineYears.Name = "FromFiveToNineYears";
            FromFiveToNineYears.Size = new Size(78, 24);
            FromFiveToNineYears.TabIndex = 4;
            FromFiveToNineYears.TabStop = true;
            FromFiveToNineYears.Text = "5-9 лет";
            FromFiveToNineYears.UseVisualStyleBackColor = true;
            // 
            // LessThanOneYear
            // 
            LessThanOneYear.AutoSize = true;
            LessThanOneYear.Location = new Point(22, 66);
            LessThanOneYear.Name = "LessThanOneYear";
            LessThanOneYear.Size = new Size(135, 24);
            LessThanOneYear.TabIndex = 3;
            LessThanOneYear.TabStop = true;
            LessThanOneYear.Text = "Меньше 1 года";
            LessThanOneYear.UseVisualStyleBackColor = true;
            // 
            // MoreThanTenYears
            // 
            MoreThanTenYears.AutoSize = true;
            MoreThanTenYears.Location = new Point(561, 26);
            MoreThanTenYears.Name = "MoreThanTenYears";
            MoreThanTenYears.Size = new Size(82, 24);
            MoreThanTenYears.TabIndex = 2;
            MoreThanTenYears.TabStop = true;
            MoreThanTenYears.Text = "10+ лет";
            MoreThanTenYears.UseVisualStyleBackColor = true;
            // 
            // FromOneToFiveYears
            // 
            FromOneToFiveYears.AutoSize = true;
            FromOneToFiveYears.Location = new Point(298, 26);
            FromOneToFiveYears.Name = "FromOneToFiveYears";
            FromOneToFiveYears.Size = new Size(78, 24);
            FromOneToFiveYears.TabIndex = 1;
            FromOneToFiveYears.TabStop = true;
            FromOneToFiveYears.Text = "1-5 лет";
            FromOneToFiveYears.UseVisualStyleBackColor = true;
            // 
            // NotWorking
            // 
            NotWorking.AutoSize = true;
            NotWorking.Location = new Point(22, 26);
            NotWorking.Name = "NotWorking";
            NotWorking.Size = new Size(102, 24);
            NotWorking.TabIndex = 0;
            NotWorking.TabStop = true;
            NotWorking.Text = "Нет опыта";
            NotWorking.UseVisualStyleBackColor = true;
            // 
            // OtherInfo
            // 
            OtherInfo.Controls.Add(DriverCategoryD);
            OtherInfo.Controls.Add(DriverCategoryC);
            OtherInfo.Controls.Add(DriverCategoryB);
            OtherInfo.Controls.Add(DriverCategoryA);
            OtherInfo.Controls.Add(DriverCategory);
            OtherInfo.Controls.Add(DriverLicense);
            OtherInfo.Controls.Add(HaveAPersonalCar);
            OtherInfo.Location = new Point(23, 410);
            OtherInfo.Name = "OtherInfo";
            OtherInfo.Size = new Size(318, 149);
            OtherInfo.TabIndex = 16;
            OtherInfo.TabStop = false;
            OtherInfo.Text = "Другие Сведения: ";
            // 
            // DriverCategoryD
            // 
            DriverCategoryD.AutoSize = true;
            DriverCategoryD.Location = new Point(161, 115);
            DriverCategoryD.Name = "DriverCategoryD";
            DriverCategoryD.Size = new Size(42, 24);
            DriverCategoryD.TabIndex = 6;
            DriverCategoryD.Text = "D";
            DriverCategoryD.UseVisualStyleBackColor = true;
            // 
            // DriverCategoryC
            // 
            DriverCategoryC.AutoSize = true;
            DriverCategoryC.Location = new Point(110, 115);
            DriverCategoryC.Name = "DriverCategoryC";
            DriverCategoryC.Size = new Size(40, 24);
            DriverCategoryC.TabIndex = 5;
            DriverCategoryC.Text = "C";
            DriverCategoryC.UseVisualStyleBackColor = true;
            // 
            // DriverCategoryB
            // 
            DriverCategoryB.AutoSize = true;
            DriverCategoryB.Location = new Point(66, 115);
            DriverCategoryB.Name = "DriverCategoryB";
            DriverCategoryB.Size = new Size(40, 24);
            DriverCategoryB.TabIndex = 4;
            DriverCategoryB.Text = "B";
            DriverCategoryB.UseVisualStyleBackColor = true;
            // 
            // DriverCategoryA
            // 
            DriverCategoryA.AutoSize = true;
            DriverCategoryA.Location = new Point(22, 115);
            DriverCategoryA.Name = "DriverCategoryA";
            DriverCategoryA.Size = new Size(41, 24);
            DriverCategoryA.TabIndex = 3;
            DriverCategoryA.Text = "A";
            DriverCategoryA.UseVisualStyleBackColor = true;
            // 
            // DriverCategory
            // 
            DriverCategory.AutoSize = true;
            DriverCategory.Location = new Point(13, 92);
            DriverCategory.Name = "DriverCategory";
            DriverCategory.Size = new Size(299, 20);
            DriverCategory.TabIndex = 2;
            DriverCategory.Text = "Категория водительского удостоверения:";
            // 
            // DriverLicense
            // 
            DriverLicense.AutoSize = true;
            DriverLicense.Location = new Point(13, 56);
            DriverLicense.Name = "DriverLicense";
            DriverLicense.Size = new Size(236, 24);
            DriverLicense.TabIndex = 1;
            DriverLicense.Text = "Водительское удостоверение";
            DriverLicense.UseVisualStyleBackColor = true;
            // 
            // HaveAPersonalCar
            // 
            HaveAPersonalCar.AutoSize = true;
            HaveAPersonalCar.Location = new Point(13, 26);
            HaveAPersonalCar.Name = "HaveAPersonalCar";
            HaveAPersonalCar.Size = new Size(176, 24);
            HaveAPersonalCar.TabIndex = 0;
            HaveAPersonalCar.Text = "Личный автомобиль";
            HaveAPersonalCar.UseVisualStyleBackColor = true;
            // 
            // SalaryRange
            // 
            SalaryRange.Controls.Add(ToLabel);
            SalaryRange.Controls.Add(FromLabel);
            SalaryRange.Controls.Add(MaxSalary);
            SalaryRange.Controls.Add(MinSalary);
            SalaryRange.Location = new Point(371, 410);
            SalaryRange.Name = "SalaryRange";
            SalaryRange.Size = new Size(402, 65);
            SalaryRange.TabIndex = 17;
            SalaryRange.TabStop = false;
            SalaryRange.Text = "Объем заработной платы: ";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(214, 28);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(28, 20);
            ToLabel.TabIndex = 3;
            ToLabel.Text = "До";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(14, 28);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(26, 20);
            FromLabel.TabIndex = 2;
            FromLabel.Text = "От";
            // 
            // MaxSalary
            // 
            MaxSalary.Location = new Point(246, 26);
            MaxSalary.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            MaxSalary.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            MaxSalary.Name = "MaxSalary";
            MaxSalary.Size = new Size(150, 27);
            MaxSalary.TabIndex = 1;
            MaxSalary.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // MinSalary
            // 
            MinSalary.Location = new Point(46, 26);
            MinSalary.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            MinSalary.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            MinSalary.Name = "MinSalary";
            MinSalary.Size = new Size(150, 27);
            MinSalary.TabIndex = 0;
            MinSalary.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // TimeToWork
            // 
            TimeToWork.Controls.Add(TimeWork);
            TimeToWork.Controls.Add(WorkAtHome);
            TimeToWork.Controls.Add(PartTime);
            TimeToWork.Controls.Add(FullTime);
            TimeToWork.Location = new Point(371, 481);
            TimeToWork.Name = "TimeToWork";
            TimeToWork.Size = new Size(402, 78);
            TimeToWork.TabIndex = 18;
            TimeToWork.TabStop = false;
            TimeToWork.Text = "Предпочитаемый график работы";
            // 
            // TimeWork
            // 
            TimeWork.AutoSize = true;
            TimeWork.Location = new Point(223, 48);
            TimeWork.Name = "TimeWork";
            TimeWork.Size = new Size(163, 24);
            TimeWork.TabIndex = 3;
            TimeWork.TabStop = true;
            TimeWork.Text = "Посменная работа";
            TimeWork.UseVisualStyleBackColor = true;
            // 
            // WorkAtHome
            // 
            WorkAtHome.AutoSize = true;
            WorkAtHome.Location = new Point(14, 48);
            WorkAtHome.Name = "WorkAtHome";
            WorkAtHome.Size = new Size(138, 24);
            WorkAtHome.TabIndex = 2;
            WorkAtHome.TabStop = true;
            WorkAtHome.Text = "Работа на дому";
            WorkAtHome.UseVisualStyleBackColor = true;
            // 
            // PartTime
            // 
            PartTime.AutoSize = true;
            PartTime.Location = new Point(223, 19);
            PartTime.Name = "PartTime";
            PartTime.Size = new Size(175, 24);
            PartTime.TabIndex = 1;
            PartTime.TabStop = true;
            PartTime.Text = "Частичная занятость";
            PartTime.UseVisualStyleBackColor = true;
            // 
            // FullTime
            // 
            FullTime.AutoSize = true;
            FullTime.Location = new Point(14, 21);
            FullTime.Name = "FullTime";
            FullTime.Size = new Size(155, 24);
            FullTime.TabIndex = 0;
            FullTime.TabStop = true;
            FullTime.Text = "Полная занятость";
            FullTime.UseVisualStyleBackColor = true;
            // 
            // AboutMe
            // 
            AboutMe.Location = new Point(23, 595);
            AboutMe.Name = "AboutMe";
            AboutMe.Size = new Size(750, 147);
            AboutMe.TabIndex = 19;
            AboutMe.Text = "";
            // 
            // AboutMeLabel
            // 
            AboutMeLabel.AutoSize = true;
            AboutMeLabel.Location = new Point(23, 572);
            AboutMeLabel.Name = "AboutMeLabel";
            AboutMeLabel.Size = new Size(63, 20);
            AboutMeLabel.TabIndex = 20;
            AboutMeLabel.Text = "О себе: ";
            // 
            // SaveData
            // 
            SaveData.Location = new Point(272, 748);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(154, 29);
            SaveData.TabIndex = 21;
            SaveData.Text = "Сохранить данные";
            SaveData.UseVisualStyleBackColor = true;
            SaveData.Click += SaveButton_Click;
            // 
            // ClearForm
            // 
            ClearForm.Location = new Point(449, 748);
            ClearForm.Name = "ClearForm";
            ClearForm.Size = new Size(154, 29);
            ClearForm.TabIndex = 22;
            ClearForm.Text = "Очистить форму";
            ClearForm.UseVisualStyleBackColor = true;
            ClearForm.Click += ClearButton_Click;
            // 
            // CancelForm
            // 
            CancelForm.Location = new Point(619, 748);
            CancelForm.Name = "CancelForm";
            CancelForm.Size = new Size(154, 29);
            CancelForm.TabIndex = 23;
            CancelForm.Text = "Закрыть форму";
            CancelForm.UseVisualStyleBackColor = true;
            CancelForm.Click += CancelButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 783);
            Controls.Add(CancelForm);
            Controls.Add(ClearForm);
            Controls.Add(SaveData);
            Controls.Add(AboutMeLabel);
            Controls.Add(AboutMe);
            Controls.Add(TimeToWork);
            Controls.Add(SalaryRange);
            Controls.Add(OtherInfo);
            Controls.Add(WorkExperience);
            Controls.Add(PhoneNumber);
            Controls.Add(CallOperator);
            Controls.Add(phoneLabel);
            Controls.Add(LocationCity);
            Controls.Add(Email);
            Controls.Add(EMailLabel);
            Controls.Add(LocationLabel);
            Controls.Add(BirthDateGroupBox);
            Controls.Add(Sex);
            Controls.Add(MiddleName);
            Controls.Add(Name);
            Controls.Add(Surname);
            Controls.Add(MiddleNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            Text = "Task4";
            Sex.ResumeLayout(false);
            Sex.PerformLayout();
            BirthDateGroupBox.ResumeLayout(false);
            WorkExperience.ResumeLayout(false);
            WorkExperience.PerformLayout();
            OtherInfo.ResumeLayout(false);
            OtherInfo.PerformLayout();
            SalaryRange.ResumeLayout(false);
            SalaryRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinSalary).EndInit();
            TimeToWork.ResumeLayout(false);
            TimeToWork.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SurnameLabel;
        private Label NameLabel;
        private Label MiddleNameLabel;
        private TextBox Surname;
        private TextBox Name;
        private TextBox MiddleName;
        private GroupBox Sex;
        private RadioButton Female;
        private RadioButton Male;
        private GroupBox BirthDateGroupBox;
        private DateTimePicker DateBirth;
        private Label LocationLabel;
        private Label EMailLabel;
        private TextBox Email;
        private ComboBox LocationCity;
        private Label phoneLabel;
        private ComboBox CallOperator;
        private TextBox PhoneNumber;
        private GroupBox WorkExperience;
        private RadioButton FromFiveToNineYears;
        private RadioButton LessThanOneYear;
        private RadioButton MoreThanTenYears;
        private RadioButton FromOneToFiveYears;
        private RadioButton NotWorking;
        private GroupBox OtherInfo;
        private CheckBox DriverCategoryD;
        private CheckBox DriverCategoryC;
        private CheckBox DriverCategoryB;
        private CheckBox DriverCategoryA;
        private Label DriverCategory;
        private CheckBox DriverLicense;
        private CheckBox HaveAPersonalCar;
        private GroupBox SalaryRange;
        private Label ToLabel;
        private Label FromLabel;
        private NumericUpDown MaxSalary;
        private NumericUpDown MinSalary;
        private GroupBox TimeToWork;
        private RadioButton TimeWork;
        private RadioButton WorkAtHome;
        private RadioButton PartTime;
        private RadioButton FullTime;
        private RichTextBox AboutMe;
        private Label AboutMeLabel;
        private Button SaveData;
        private Button ClearForm;
        private Button CancelForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

