using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (IsPalindrome(input))
            {
                lblResult.Text = "Текст является палиндромом";
            }
            else
            {
                lblResult.Text = "Текст не является палиндромом";
            }
        }

        private bool IsPalindrome(string text)
        {
            // Удаляем пробелы и знаки препинания, приводим к одному регистру
            var filteredText = new string(text.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
            // Проверяем на палиндром
            return filteredText.SequenceEqual(filteredText.Reverse());
        }
    }
}
