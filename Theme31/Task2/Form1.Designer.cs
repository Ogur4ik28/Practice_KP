namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательный компонентный контейнер.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождение всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Автоматически созданный код конструктором форм Windows

        /// <summary>
        /// Метод, требуемый для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tourDataGridView = new System.Windows.Forms.DataGridView();
            this.touristDataGridView = new System.Windows.Forms.DataGridView();
            this.selectToursButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.addTouristButton = new System.Windows.Forms.Button();
            this.updateTouristButton = new System.Windows.Forms.Button();
            this.navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.navigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.navigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.navigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.navigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.navigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.touristIDTextBox = new System.Windows.Forms.TextBox();
            this.touristSurnameTextBox = new System.Windows.Forms.TextBox();
            this.touristNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).BeginInit();
            this.navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourDataGridView
            // 
            this.tourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourDataGridView.Location = new System.Drawing.Point(12, 84);
            this.tourDataGridView.Name = "tourDataGridView";
            this.tourDataGridView.RowHeadersWidth = 82;
            this.tourDataGridView.RowTemplate.Height = 33;
            this.tourDataGridView.Size = new System.Drawing.Size(909, 293);
            this.tourDataGridView.TabIndex = 0;
            // 
            // touristDataGridView
            // 
            this.touristDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.touristDataGridView.Location = new System.Drawing.Point(12, 396);
            this.touristDataGridView.Name = "touristDataGridView";
            this.touristDataGridView.RowHeadersWidth = 82;
            this.touristDataGridView.RowTemplate.Height = 33;
            this.touristDataGridView.Size = new System.Drawing.Size(1306, 209);
            this.touristDataGridView.TabIndex = 2;
            // 
            // selectToursButton
            // 
            this.selectToursButton.Location = new System.Drawing.Point(12, 636);
            this.selectToursButton.Name = "selectToursButton";
            this.selectToursButton.Size = new System.Drawing.Size(288, 39);
            this.selectToursButton.TabIndex = 6;
            this.selectToursButton.Text = "Показать все туры";
            this.selectToursButton.UseVisualStyleBackColor = true;
            this.selectToursButton.Click += new System.EventHandler(this.SelectToursButton_Click);
            // 
            // deleteTourButton
            // 
            this.deleteTourButton.Location = new System.Drawing.Point(341, 636);
            this.deleteTourButton.Name = "deleteTourButton";
            this.deleteTourButton.Size = new System.Drawing.Size(288, 39);
            this.deleteTourButton.TabIndex = 7;
            this.deleteTourButton.Text = "Удалить тур";
            this.deleteTourButton.UseVisualStyleBackColor = true;
            this.deleteTourButton.Click += new System.EventHandler(this.DeleteTourButton_Click);
            // 
            // addTouristButton
            // 
            this.addTouristButton.Location = new System.Drawing.Point(667, 636);
            this.addTouristButton.Name = "addTouristButton";
            this.addTouristButton.Size = new System.Drawing.Size(288, 39);
            this.addTouristButton.TabIndex = 8;
            this.addTouristButton.Text = "Добавить туриста";
            this.addTouristButton.UseVisualStyleBackColor = true;
            this.addTouristButton.Click += new System.EventHandler(this.AddTouristButton_Click);
            // 
            // updateTouristButton
            // 
            this.updateTouristButton.Location = new System.Drawing.Point(995, 636);
            this.updateTouristButton.Name = "updateTouristButton";
            this.updateTouristButton.Size = new System.Drawing.Size(288, 39);
            this.updateTouristButton.TabIndex = 9;
            this.updateTouristButton.Text = "Изменить данные туриста";
            this.updateTouristButton.UseVisualStyleBackColor = true;
            this.updateTouristButton.Click += new System.EventHandler(this.UpdateTouristButton_Click);
            // 
            // navigator
            // 
            this.navigator.AddNewItem = this.navigatorAddNewItem;
            this.navigator.CountItem = this.navigatorCountItem;
            this.navigator.DeleteItem = this.navigatorDeleteItem;
            this.navigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigatorMoveFirstItem,
            this.navigatorMovePreviousItem,
            this.navigatorSeparator,
            this.navigatorPositionItem,
            this.navigatorCountItem,
            this.navigatorSeparator1,
            this.navigatorMoveNextItem,
            this.navigatorMoveLastItem,
            this.navigatorSeparator2,
            this.navigatorAddNewItem,
            this.navigatorDeleteItem});
            this.navigator.Location = new System.Drawing.Point(0, 0);
            this.navigator.MoveFirstItem = this.navigatorMoveFirstItem;
            this.navigator.MoveLastItem = this.navigatorMoveLastItem;
            this.navigator.MoveNextItem = this.navigatorMoveNextItem;
            this.navigator.MovePreviousItem = this.navigatorMovePreviousItem;
            this.navigator.Name = "navigator";
            this.navigator.PositionItem = this.navigatorPositionItem;
            this.navigator.Size = new System.Drawing.Size(1330, 50);
            this.navigator.TabIndex = 10;
            this.navigator.Text = "navigator";
            // 
            // navigatorAddNewItem
            // 
            this.navigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorAddNewItem.Image")));
            this.navigatorAddNewItem.Name = "navigatorAddNewItem";
            this.navigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.navigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorAddNewItem.Text = "Добавить";
            // 
            // navigatorCountItem
            // 
            this.navigatorCountItem.Name = "navigatorCountItem";
            this.navigatorCountItem.Size = new System.Drawing.Size(86, 44);
            this.navigatorCountItem.Text = "для {0}";
            this.navigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // navigatorDeleteItem
            // 
            this.navigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorDeleteItem.Image")));
            this.navigatorDeleteItem.Name = "navigatorDeleteItem";
            this.navigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.navigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorDeleteItem.Text = "Удалить";
            // 
            // navigatorMoveFirstItem
            // 
            this.navigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveFirstItem.Image")));
            this.navigatorMoveFirstItem.Name = "navigatorMoveFirstItem";
            this.navigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.navigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // navigatorMovePreviousItem
            // 
            this.navigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMovePreviousItem.Image")));
            this.navigatorMovePreviousItem.Name = "navigatorMovePreviousItem";
            this.navigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.navigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // navigatorSeparator
            // 
            this.navigatorSeparator.Name = "navigatorSeparator";
            this.navigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // navigatorPositionItem
            // 
            this.navigatorPositionItem.AccessibleName = "Положение";
            this.navigatorPositionItem.AutoSize = false;
            this.navigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navigatorPositionItem.Name = "navigatorPositionItem";
            this.navigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.navigatorPositionItem.Text = "0";
            this.navigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // navigatorSeparator1
            // 
            this.navigatorSeparator1.Name = "navigatorSeparator1";
            this.navigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // navigatorMoveNextItem
            // 
            this.navigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveNextItem.Image")));
            this.navigatorMoveNextItem.Name = "navigatorMoveNextItem";
            this.navigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.navigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // navigatorMoveLastItem
            // 
            this.navigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("navigatorMoveLastItem.Image")));
            this.navigatorMoveLastItem.Name = "navigatorMoveLastItem";
            this.navigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.navigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.navigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // navigatorSeparator2
            // 
            this.navigatorSeparator2.Name = "navigatorSeparator2";
            this.navigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // touristIDTextBox
            // 
            this.touristIDTextBox.Location = new System.Drawing.Point(946, 212);
            this.touristIDTextBox.Name = "touristIDTextBox";
            this.touristIDTextBox.Size = new System.Drawing.Size(372, 31);
            this.touristIDTextBox.TabIndex = 5;
            // 
            // touristSurnameTextBox
            // 
            this.touristSurnameTextBox.Location = new System.Drawing.Point(946, 157);
            this.touristSurnameTextBox.Name = "touristSurnameTextBox";
            this.touristSurnameTextBox.Size = new System.Drawing.Size(372, 31);
            this.touristSurnameTextBox.TabIndex = 4;
            // 
            // touristNameTextBox
            // 
            this.touristNameTextBox.Location = new System.Drawing.Point(946, 104);
            this.touristNameTextBox.Name = "touristNameTextBox";
            this.touristNameTextBox.Size = new System.Drawing.Size(372, 31);
            this.touristNameTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 708);
            this.Controls.Add(this.navigator);
            this.Controls.Add(this.updateTouristButton);
            this.Controls.Add(this.addTouristButton);
            this.Controls.Add(this.deleteTourButton);
            this.Controls.Add(this.selectToursButton);
            this.Controls.Add(this.touristIDTextBox);
            this.Controls.Add(this.touristSurnameTextBox);
            this.Controls.Add(this.touristNameTextBox);
            this.Controls.Add(this.touristDataGridView);
            this.Controls.Add(this.tourDataGridView);
            this.Name = "MainForm";
            this.Text = "Travel Management";
            ((System.ComponentModel.ISupportInitialize)(this.tourDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).EndInit();
            this.navigator.ResumeLayout(false);
            this.navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tourDataGridView;
        private System.Windows.Forms.DataGridView touristDataGridView;
        private System.Windows.Forms.Button selectToursButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.Button addTouristButton;
        private System.Windows.Forms.Button updateTouristButton;
        private System.Windows.Forms.BindingNavigator navigator;
        private System.Windows.Forms.ToolStripButton navigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel navigatorCountItem;
        private System.Windows.Forms.ToolStripButton navigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton navigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton navigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator navigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox navigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator navigatorSeparator1;
        private System.Windows.Forms.ToolStripButton navigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton navigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator navigatorSeparator2;
        private System.Windows.Forms.TextBox touristIDTextBox;
        private System.Windows.Forms.TextBox touristSurnameTextBox;
        private System.Windows.Forms.TextBox touristNameTextBox;
    }
}
