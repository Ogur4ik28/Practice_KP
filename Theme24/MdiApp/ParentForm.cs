using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
            InitializeToolStrip();
            // Óñòàíîâèòå òåêóùóþ äàòó â ñòàòóñå spData
            spData.Text = DateTime.Today.ToLongDateString();
        }

        private void InitializeToolStrip()
        {
            toolStrip1.ItemClicked += new ToolStripItemClickedEventHandler(toolStrip1_ItemClicked);

            toolStripButton1.Tag = "NewDoc";
            toolStripButton1.ToolTipText = "Create new document";

            toolStripButton2.Tag = "Cascade";
            toolStripButton2.ToolTipText = "Windows cascade";

            toolStripButton3.Tag = "Title";
            toolStripButton3.ToolTipText = "Windows title";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem?.Tag != null)
            {
                switch (e.ClickedItem.Tag.ToString())
                {
                    case "NewDoc":
                        ChildForm newChild = new ChildForm
                        {
                            MdiParent = this,
                            Text = "Document " + ++openDocuments
                        };
                        newChild.Show();
                        break;
                    case "Cascade":
                        this.LayoutMdi(MdiLayout.Cascade);
                        spWin.Text = "Windows is cascade";
                        break;
                    case "Title":
                        this.LayoutMdi(MdiLayout.TileHorizontal);
                        spWin.Text = "Windows is horizontal";
                        break;
                }
            }
        }
    }
}
