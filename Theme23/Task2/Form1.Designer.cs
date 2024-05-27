
namespace Task2
{
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
            this.txtXStart = new System.Windows.Forms.TextBox();
            this.txtXEnd = new System.Windows.Forms.TextBox();
            this.txtXStep = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXStart
            // 
            this.txtXStart.Location = new System.Drawing.Point(12, 12);
            this.txtXStart.Name = "txtXStart";
            this.txtXStart.Size = new System.Drawing.Size(100, 20);
            this.txtXStart.TabIndex = 0;
            this.txtXStart.Text = "Начало X";
            // 
            // txtXEnd
            // 
            this.txtXEnd.Location = new System.Drawing.Point(118, 12);
            this.txtXEnd.Name = "txtXEnd";
            this.txtXEnd.Size = new System.Drawing.Size(100, 20);
            this.txtXEnd.TabIndex = 1;
            this.txtXEnd.Text = "Конец X";
            // 
            // txtXStep
            // 
            this.txtXStep.Location = new System.Drawing.Point(224, 12);
            this.txtXStep.Name = "txtXStep";
            this.txtXStep.Size = new System.Drawing.Size(100, 20);
            this.txtXStep.TabIndex = 2;
            this.txtXStep.Text = "Шаг X";
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(330, 10);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 3;
            this.btnPlot.Text = "Построить";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // chart
            // 
            chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chart.Location = new System.Drawing.Point(12, 41);
            chart.Name = "chart";
            chart.Size = new System.Drawing.Size(776, 397);
            chart.TabIndex = 4;
            chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.txtXStep);
            this.Controls.Add(this.txtXEnd);
            this.Controls.Add(this.txtXStart);
            this.Name = "Form1";
            this.Text = "Построитель графика функции";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtXStart;
        private System.Windows.Forms.TextBox txtXEnd;
        private System.Windows.Forms.TextBox txtXStep;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}