using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void toggleMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleMenuItem.Checked)
            {
                toggleMenuItem.Checked = false;
                childTextBox.ForeColor = Color.Black;
            }
            else
            {
                toggleMenuItem.Checked = true;
                childTextBox.ForeColor = Color.Blue;
            }
        }
    }
}
