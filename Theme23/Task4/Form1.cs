using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private TextBox textBoxType;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button addButton;

        private delegate void ControlRemovedEventHandler(Control control);

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeComponent()
        {
            // Инициализация элементов управления
            this.textBoxType = new TextBox();
            this.textBoxX = new TextBox();
            this.textBoxY = new TextBox();
            this.addButton = new Button();
            this.SuspendLayout();
            // Установка свойств элементов управления
            this.textBoxType.Location = new Point(10, 10);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new Size(100, 20);
            this.textBoxType.TabIndex = 0;
            this.textBoxX.Location = new Point(10, 40);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new Size(100, 20);
            this.textBoxX.TabIndex = 1;
            this.textBoxY.Location = new Point(10, 70);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new Size(100, 20);
            this.textBoxY.TabIndex = 2;

            this.addButton.Location = new Point(10, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new EventHandler(this.AddButton_Click);
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxType);
            this.Name = "Form1";
            this.Text = "Динамические элементы управления";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeUI()
        {
            // Подключение обработчика события MouseHover для всех элементов управления на форме
            foreach (Control control in Controls)
            {
                control.MouseHover += Control_MouseHover;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение данных о новом элементе управления из текстовых полей
            string controlType = textBoxType.Text;
            int x, y;

            if (!int.TryParse(textBoxX.Text, out x) || !int.TryParse(textBoxY.Text, out y))
            {
                MessageBox.Show("Пожалуйста, введите целые числовые значения для координат X и Y.");
                return;
            }

            // Создание нового элемента управления в зависимости от указанного типа
            switch (controlType)
            {
                case "Кнопка":
                    Button button = new Button();
                    button.Text = "Новая кнопка";
                    button.Location = new Point(x, y);
                    Controls.Add(button);
                    button.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                case "Текстовое поле":
                    TextBox textBox = new TextBox();
                    textBox.Text = "Новое текстовое поле";
                    textBox.Location = new Point(x, y);
                    Controls.Add(textBox);
                    textBox.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                case "Метка":
                    Label label = new Label();
                    label.Text = "Новая метка";
                    label.Location = new Point(x, y);
                    Controls.Add(label);
                    label.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                default:
                    MessageBox.Show("Неверный тип элемента управления. Пожалуйста, введите 'Кнопка', 'Текстовое поле' или 'Метка'.");
                    break;
            }
        }

        private void RemoveControl(Control control)
        {
            // Удаление элемента управления
            Controls.Remove(control);
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            // Удаление элемента управления при наведении мыши, если он был создан динамически
            if (sender is Control dynamicControl && !Controls.Contains(dynamicControl))
            {
                Controls.Remove(dynamicControl);
            }
        }
    }
}
