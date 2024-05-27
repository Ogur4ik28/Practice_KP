using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private double centerX, centerY, endX, endY;
        private int angle = 90;
        private readonly Pen drawingPen = new Pen(Color.DarkRed, 2);
        private System.Windows.Forms.Timer rotationTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            rotationTimer.Interval = 1000;
            rotationTimer.Start();
            this.Paint += new PaintEventHandler(Form1_Paint);
            rotationTimer.Tick += new EventHandler(rotationTimer_Tick);
        }

        private void rotationTimer_Tick(object sender, EventArgs e)
        {
            angle -= 6;
            if (angle >= 360) angle -= 360;
            double radian = angle * Math.PI / 180;
            centerX = ClientSize.Width / 2;
            centerY = ClientSize.Height / 2;
            endX = centerX + (int)(100 * Math.Cos(radian));
            endY = centerY - (int)(100 * Math.Sin(radian));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawLine(drawingPen, (float)centerX, (float)centerY, (float)endX, (float)endY);
        }
    }

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }
    }
}
