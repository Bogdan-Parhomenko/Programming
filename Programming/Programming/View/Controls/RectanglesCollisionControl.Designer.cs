namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.RectanglesHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesYTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesXTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesIdTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesHeightLabel = new System.Windows.Forms.Label();
            this.RectanglesWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesAddingLabel = new System.Windows.Forms.Label();
            this.RectanglesXLabel = new System.Windows.Forms.Label();
            this.RectanglesYLabel = new System.Windows.Forms.Label();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.RectanglesAddingListBox = new System.Windows.Forms.ListBox();
            this.RectanglesIdLabel = new System.Windows.Forms.Label();
            this.RectanglesAddingButton = new System.Windows.Forms.Button();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesDeletingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RectanglesHeightTextBox
            // 
            this.RectanglesHeightTextBox.Location = new System.Drawing.Point(51, 367);
            this.RectanglesHeightTextBox.Name = "RectanglesHeightTextBox";
            this.RectanglesHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesHeightTextBox.TabIndex = 30;
            this.RectanglesHeightTextBox.TextChanged += new System.EventHandler(this.RectanglesHeightTextBox_TextChanged);
            // 
            // RectanglesWidthTextBox
            // 
            this.RectanglesWidthTextBox.Location = new System.Drawing.Point(51, 341);
            this.RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            this.RectanglesWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesWidthTextBox.TabIndex = 29;
            this.RectanglesWidthTextBox.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // RectanglesYTextBox
            // 
            this.RectanglesYTextBox.Location = new System.Drawing.Point(51, 315);
            this.RectanglesYTextBox.Name = "RectanglesYTextBox";
            this.RectanglesYTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesYTextBox.TabIndex = 28;
            this.RectanglesYTextBox.TextChanged += new System.EventHandler(this.RectanglesYTextBox_TextChanged);
            // 
            // RectanglesXTextBox
            // 
            this.RectanglesXTextBox.Location = new System.Drawing.Point(51, 289);
            this.RectanglesXTextBox.Name = "RectanglesXTextBox";
            this.RectanglesXTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesXTextBox.TabIndex = 27;
            this.RectanglesXTextBox.TextChanged += new System.EventHandler(this.RectanglesXTextBox_TextChanged);
            // 
            // RectanglesIdTextBox
            // 
            this.RectanglesIdTextBox.Location = new System.Drawing.Point(51, 263);
            this.RectanglesIdTextBox.Name = "RectanglesIdTextBox";
            this.RectanglesIdTextBox.ReadOnly = true;
            this.RectanglesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.RectanglesIdTextBox.TabIndex = 26;
            // 
            // RectanglesHeightLabel
            // 
            this.RectanglesHeightLabel.AutoSize = true;
            this.RectanglesHeightLabel.Location = new System.Drawing.Point(4, 370);
            this.RectanglesHeightLabel.Name = "RectanglesHeightLabel";
            this.RectanglesHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.RectanglesHeightLabel.TabIndex = 25;
            this.RectanglesHeightLabel.Text = "Height:";
            // 
            // RectanglesWidthLabel
            // 
            this.RectanglesWidthLabel.AutoSize = true;
            this.RectanglesWidthLabel.Location = new System.Drawing.Point(7, 344);
            this.RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            this.RectanglesWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.RectanglesWidthLabel.TabIndex = 24;
            this.RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesAddingLabel
            // 
            this.RectanglesAddingLabel.AutoSize = true;
            this.RectanglesAddingLabel.Location = new System.Drawing.Point(3, 3);
            this.RectanglesAddingLabel.Name = "RectanglesAddingLabel";
            this.RectanglesAddingLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesAddingLabel.TabIndex = 16;
            this.RectanglesAddingLabel.Text = "Rectangles:";
            // 
            // RectanglesXLabel
            // 
            this.RectanglesXLabel.AutoSize = true;
            this.RectanglesXLabel.Location = new System.Drawing.Point(28, 292);
            this.RectanglesXLabel.Name = "RectanglesXLabel";
            this.RectanglesXLabel.Size = new System.Drawing.Size(17, 13);
            this.RectanglesXLabel.TabIndex = 22;
            this.RectanglesXLabel.Text = "X:";
            // 
            // RectanglesYLabel
            // 
            this.RectanglesYLabel.AutoSize = true;
            this.RectanglesYLabel.Location = new System.Drawing.Point(28, 318);
            this.RectanglesYLabel.Name = "RectanglesYLabel";
            this.RectanglesYLabel.Size = new System.Drawing.Size(17, 13);
            this.RectanglesYLabel.TabIndex = 23;
            this.RectanglesYLabel.Text = "Y:";
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(310, 4);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(475, 418);
            this.CanvasPanel.TabIndex = 15;
            // 
            // RectanglesAddingListBox
            // 
            this.RectanglesAddingListBox.FormattingEnabled = true;
            this.RectanglesAddingListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesAddingListBox.Name = "RectanglesAddingListBox";
            this.RectanglesAddingListBox.Size = new System.Drawing.Size(298, 186);
            this.RectanglesAddingListBox.TabIndex = 17;
            this.RectanglesAddingListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesAddingListBox_SelectedIndexChanged);
            // 
            // RectanglesIdLabel
            // 
            this.RectanglesIdLabel.AutoSize = true;
            this.RectanglesIdLabel.Location = new System.Drawing.Point(26, 266);
            this.RectanglesIdLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RectanglesIdLabel.Name = "RectanglesIdLabel";
            this.RectanglesIdLabel.Size = new System.Drawing.Size(19, 13);
            this.RectanglesIdLabel.TabIndex = 21;
            this.RectanglesIdLabel.Text = "Id:";
            // 
            // RectanglesAddingButton
            // 
            this.RectanglesAddingButton.Location = new System.Drawing.Point(6, 211);
            this.RectanglesAddingButton.Name = "RectanglesAddingButton";
            this.RectanglesAddingButton.Size = new System.Drawing.Size(75, 23);
            this.RectanglesAddingButton.TabIndex = 18;
            this.RectanglesAddingButton.Text = "Add";
            this.RectanglesAddingButton.UseVisualStyleBackColor = true;
            this.RectanglesAddingButton.Click += new System.EventHandler(this.RectanglesAddingButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(3, 247);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesDeletingButton
            // 
            this.RectanglesDeletingButton.Location = new System.Drawing.Point(102, 211);
            this.RectanglesDeletingButton.Name = "RectanglesDeletingButton";
            this.RectanglesDeletingButton.Size = new System.Drawing.Size(75, 23);
            this.RectanglesDeletingButton.TabIndex = 19;
            this.RectanglesDeletingButton.Text = "Delete";
            this.RectanglesDeletingButton.UseVisualStyleBackColor = true;
            this.RectanglesDeletingButton.Click += new System.EventHandler(this.RectanglesDeletingButton_Click);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesHeightTextBox);
            this.Controls.Add(this.RectanglesWidthTextBox);
            this.Controls.Add(this.RectanglesYTextBox);
            this.Controls.Add(this.RectanglesXTextBox);
            this.Controls.Add(this.RectanglesIdTextBox);
            this.Controls.Add(this.RectanglesHeightLabel);
            this.Controls.Add(this.RectanglesWidthLabel);
            this.Controls.Add(this.RectanglesAddingLabel);
            this.Controls.Add(this.RectanglesXLabel);
            this.Controls.Add(this.RectanglesYLabel);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.RectanglesAddingListBox);
            this.Controls.Add(this.RectanglesIdLabel);
            this.Controls.Add(this.RectanglesAddingButton);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectanglesDeletingButton);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(788, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RectanglesHeightTextBox;
        private System.Windows.Forms.TextBox RectanglesWidthTextBox;
        private System.Windows.Forms.TextBox RectanglesYTextBox;
        private System.Windows.Forms.TextBox RectanglesXTextBox;
        private System.Windows.Forms.TextBox RectanglesIdTextBox;
        private System.Windows.Forms.Label RectanglesHeightLabel;
        private System.Windows.Forms.Label RectanglesWidthLabel;
        private System.Windows.Forms.Label RectanglesAddingLabel;
        private System.Windows.Forms.Label RectanglesXLabel;
        private System.Windows.Forms.Label RectanglesYLabel;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.ListBox RectanglesAddingListBox;
        private System.Windows.Forms.Label RectanglesIdLabel;
        private System.Windows.Forms.Button RectanglesAddingButton;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Button RectanglesDeletingButton;
    }
}
