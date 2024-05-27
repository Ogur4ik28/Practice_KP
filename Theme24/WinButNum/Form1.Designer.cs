namespace WinButNum
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
            colorChangingButton1 = new CustomButtonControl.ColorChangingButton();
            SuspendLayout();
            // 
            // colorChangingButton1
            // 
            colorChangingButton1.Location = new Point(532, 131);
            colorChangingButton1.Name = "colorChangingButton1";
            colorChangingButton1.Size = new Size(94, 29);
            colorChangingButton1.TabIndex = 0;
            colorChangingButton1.Text = "colorChangingButton1";
            colorChangingButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(colorChangingButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomButtonControl.ColorChangingButton colorChangingButton1;
    }
}
