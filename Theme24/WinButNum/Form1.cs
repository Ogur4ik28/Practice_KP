using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClickButton clickButton = new ClickButton();
            clickButton.Text = "ÍÀÊËÈÊÀÉ ÍÀ ÌÅÍß ÑÈËÜÍÎ";
            clickButton.Location = new System.Drawing.Point(50, 50);
            clickButton.Size = new System.Drawing.Size(100, 100);
            Controls.Add(clickButton);
        }
    }
}

