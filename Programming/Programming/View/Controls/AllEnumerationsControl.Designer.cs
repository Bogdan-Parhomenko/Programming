namespace Programming.View.Controls
{
    partial class AllEnumerationsControl
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
            this.EnumsEnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsChooseIntValueLabel = new System.Windows.Forms.Label();
            this.EnumsChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumsChooseEnumirationLabel = new System.Windows.Forms.Label();
            this.EnumsIntValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumsEnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsEnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsEnumerationsGroupBox
            // 
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsChooseIntValueLabel);
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsChooseValueLabel);
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsChooseEnumirationLabel);
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsIntValueTextBox);
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsEnumsListBox);
            this.EnumsEnumerationsGroupBox.Controls.Add(this.EnumsValuesListBox);
            this.EnumsEnumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsEnumerationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsEnumerationsGroupBox.Name = "EnumsEnumerationsGroupBox";
            this.EnumsEnumerationsGroupBox.Size = new System.Drawing.Size(780, 203);
            this.EnumsEnumerationsGroupBox.TabIndex = 2;
            this.EnumsEnumerationsGroupBox.TabStop = false;
            this.EnumsEnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumsChooseIntValueLabel
            // 
            this.EnumsChooseIntValueLabel.AutoSize = true;
            this.EnumsChooseIntValueLabel.Location = new System.Drawing.Point(300, 16);
            this.EnumsChooseIntValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumsChooseIntValueLabel.Name = "EnumsChooseIntValueLabel";
            this.EnumsChooseIntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.EnumsChooseIntValueLabel.TabIndex = 5;
            this.EnumsChooseIntValueLabel.Text = "Int value:";
            // 
            // EnumsChooseValueLabel
            // 
            this.EnumsChooseValueLabel.AutoSize = true;
            this.EnumsChooseValueLabel.Location = new System.Drawing.Point(153, 16);
            this.EnumsChooseValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumsChooseValueLabel.Name = "EnumsChooseValueLabel";
            this.EnumsChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.EnumsChooseValueLabel.TabIndex = 4;
            this.EnumsChooseValueLabel.Text = "Choose value:";
            // 
            // EnumsChooseEnumirationLabel
            // 
            this.EnumsChooseEnumirationLabel.AutoSize = true;
            this.EnumsChooseEnumirationLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsChooseEnumirationLabel.Name = "EnumsChooseEnumirationLabel";
            this.EnumsChooseEnumirationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsChooseEnumirationLabel.TabIndex = 3;
            this.EnumsChooseEnumirationLabel.Text = "Choose enumeration:";
            // 
            // EnumsIntValueTextBox
            // 
            this.EnumsIntValueTextBox.Location = new System.Drawing.Point(303, 32);
            this.EnumsIntValueTextBox.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.EnumsIntValueTextBox.Name = "EnumsIntValueTextBox";
            this.EnumsIntValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnumsIntValueTextBox.TabIndex = 2;
            // 
            // EnumsEnumsListBox
            // 
            this.EnumsEnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsEnumsListBox.FormattingEnabled = true;
            this.EnumsEnumsListBox.IntegralHeight = false;
            this.EnumsEnumsListBox.Location = new System.Drawing.Point(9, 32);
            this.EnumsEnumsListBox.Name = "EnumsEnumsListBox";
            this.EnumsEnumsListBox.Size = new System.Drawing.Size(120, 165);
            this.EnumsEnumsListBox.TabIndex = 1;
            // 
            // EnumsValuesListBox
            // 
            this.EnumsValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsValuesListBox.FormattingEnabled = true;
            this.EnumsValuesListBox.IntegralHeight = false;
            this.EnumsValuesListBox.Location = new System.Drawing.Point(156, 32);
            this.EnumsValuesListBox.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.EnumsValuesListBox.Name = "EnumsValuesListBox";
            this.EnumsValuesListBox.Size = new System.Drawing.Size(120, 165);
            this.EnumsValuesListBox.TabIndex = 0;
            // 
            // AllEnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsEnumerationsGroupBox);
            this.Name = "AllEnumerationsControl";
            this.Size = new System.Drawing.Size(780, 203);
            this.EnumsEnumerationsGroupBox.ResumeLayout(false);
            this.EnumsEnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumsEnumerationsGroupBox;
        private System.Windows.Forms.Label EnumsChooseIntValueLabel;
        private System.Windows.Forms.Label EnumsChooseValueLabel;
        private System.Windows.Forms.Label EnumsChooseEnumirationLabel;
        private System.Windows.Forms.TextBox EnumsIntValueTextBox;
        private System.Windows.Forms.ListBox EnumsEnumsListBox;
        private System.Windows.Forms.ListBox EnumsValuesListBox;
    }
}
