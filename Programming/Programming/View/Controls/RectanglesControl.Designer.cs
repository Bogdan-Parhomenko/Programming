namespace Programming.View.Controls
{
    partial class RectanglesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CenterGroupBox = new System.Windows.Forms.GroupBox();
            this.YCenterTextBox = new System.Windows.Forms.TextBox();
            this.YCenterLabel = new System.Windows.Forms.Label();
            this.XCenterLabel = new System.Windows.Forms.Label();
            this.XCenterTextBox = new System.Windows.Forms.TextBox();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.CenterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.CenterGroupBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.HeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.HeightLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(390, 418);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(132, 261);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(129, 245);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 9;
            this.IdLabel.Text = "Id:";
            // 
            // CenterGroupBox
            // 
            this.CenterGroupBox.Controls.Add(this.YCenterTextBox);
            this.CenterGroupBox.Controls.Add(this.YCenterLabel);
            this.CenterGroupBox.Controls.Add(this.XCenterLabel);
            this.CenterGroupBox.Controls.Add(this.XCenterTextBox);
            this.CenterGroupBox.Location = new System.Drawing.Point(132, 139);
            this.CenterGroupBox.Name = "CenterGroupBox";
            this.CenterGroupBox.Size = new System.Drawing.Size(150, 103);
            this.CenterGroupBox.TabIndex = 8;
            this.CenterGroupBox.TabStop = false;
            this.CenterGroupBox.Text = "Center";
            // 
            // YCenterTextBox
            // 
            this.YCenterTextBox.Location = new System.Drawing.Point(9, 71);
            this.YCenterTextBox.Name = "YCenterTextBox";
            this.YCenterTextBox.ReadOnly = true;
            this.YCenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.YCenterTextBox.TabIndex = 10;
            // 
            // YCenterLabel
            // 
            this.YCenterLabel.AutoSize = true;
            this.YCenterLabel.Location = new System.Drawing.Point(6, 55);
            this.YCenterLabel.Name = "YCenterLabel";
            this.YCenterLabel.Size = new System.Drawing.Size(17, 13);
            this.YCenterLabel.TabIndex = 12;
            this.YCenterLabel.Text = "Y:";
            // 
            // XCenterLabel
            // 
            this.XCenterLabel.AutoSize = true;
            this.XCenterLabel.Location = new System.Drawing.Point(6, 16);
            this.XCenterLabel.Name = "XCenterLabel";
            this.XCenterLabel.Size = new System.Drawing.Size(17, 13);
            this.XCenterLabel.TabIndex = 11;
            this.XCenterLabel.Text = "X:";
            // 
            // XCenterTextBox
            // 
            this.XCenterTextBox.Location = new System.Drawing.Point(9, 32);
            this.XCenterTextBox.Name = "XCenterTextBox";
            this.XCenterTextBox.ReadOnly = true;
            this.XCenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.XCenterTextBox.TabIndex = 9;
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(132, 287);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(75, 25);
            this.RectangleButton.TabIndex = 7;
            this.RectangleButton.Text = "Find";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(132, 113);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(150, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(132, 74);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(150, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(132, 35);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(150, 20);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(129, 97);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(129, 58);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(129, 19);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.IntegralHeight = false;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 393);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(390, 418);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.CenterGroupBox.ResumeLayout(false);
            this.CenterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.GroupBox CenterGroupBox;
        private System.Windows.Forms.TextBox YCenterTextBox;
        private System.Windows.Forms.Label YCenterLabel;
        private System.Windows.Forms.Label XCenterLabel;
        private System.Windows.Forms.TextBox XCenterTextBox;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
