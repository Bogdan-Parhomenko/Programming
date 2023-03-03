namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumerationsTabPage = new System.Windows.Forms.TabPage();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InsertedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumirationLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.IntLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonHandleLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.EnumerationsTabPage.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.InsertedTableLayoutPanel.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumerationsTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // EnumerationsTabPage
            // 
            this.EnumerationsTabPage.Controls.Add(this.MainTableLayoutPanel);
            this.EnumerationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationsTabPage.Name = "EnumerationsTabPage";
            this.EnumerationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationsTabPage.Size = new System.Drawing.Size(792, 424);
            this.EnumerationsTabPage.TabIndex = 0;
            this.EnumerationsTabPage.Text = "Enums";
            this.EnumerationsTabPage.UseVisualStyleBackColor = true;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(303, 32);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValueTextBox.TabIndex = 2;
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 32);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 165);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.Location = new System.Drawing.Point(156, 32);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 165);
            this.ValuesListBox.TabIndex = 0;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Controls.Add(this.InsertedTableLayoutPanel, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.EnumerationsGroupBox, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.MainTableLayoutPanel.TabIndex = 3;
            // 
            // InsertedTableLayoutPanel
            // 
            this.InsertedTableLayoutPanel.ColumnCount = 2;
            this.InsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InsertedTableLayoutPanel.Controls.Add(this.WeekdayParsingGroupBox, 0, 0);
            this.InsertedTableLayoutPanel.Controls.Add(this.SeasonHandleGroupBox, 1, 0);
            this.InsertedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertedTableLayoutPanel.Location = new System.Drawing.Point(0, 209);
            this.InsertedTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InsertedTableLayoutPanel.Name = "InsertedTableLayoutPanel";
            this.InsertedTableLayoutPanel.RowCount = 1;
            this.InsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InsertedTableLayoutPanel.Size = new System.Drawing.Size(786, 209);
            this.InsertedTableLayoutPanel.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(387, 203);
            this.WeekdayParsingGroupBox.TabIndex = 0;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleComboBox);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(396, 3);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(387, 203);
            this.SeasonHandleGroupBox.TabIndex = 1;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumirationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(780, 203);
            this.EnumerationsGroupBox.TabIndex = 1;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumirationLabel
            // 
            this.EnumirationLabel.AutoSize = true;
            this.EnumirationLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumirationLabel.Name = "EnumirationLabel";
            this.EnumirationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumirationLabel.TabIndex = 3;
            this.EnumirationLabel.Text = "Choose enumeration:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(153, 16);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(300, 16);
            this.IntLabel.Margin = new System.Windows.Forms.Padding(0);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(51, 13);
            this.IntLabel.TabIndex = 5;
            this.IntLabel.Text = "Int value:";
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(6, 28);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekdayParsingLabel.TabIndex = 0;
            this.WeekdayParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(9, 44);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(200, 20);
            this.WeekdayParsingTextBox.TabIndex = 1;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(215, 44);
            this.WeekdayParsingButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 20);
            this.WeekdayParsingButton.TabIndex = 2;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(6, 43);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonHandleComboBox.TabIndex = 0;
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(133, 43);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonHandleButton.TabIndex = 1;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleLabel
            // 
            this.SeasonHandleLabel.AutoSize = true;
            this.SeasonHandleLabel.Location = new System.Drawing.Point(3, 27);
            this.SeasonHandleLabel.Name = "SeasonHandleLabel";
            this.SeasonHandleLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonHandleLabel.TabIndex = 2;
            this.SeasonHandleLabel.Text = "Choose season:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programmin Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.EnumerationsTabPage.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.InsertedTableLayoutPanel.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumerationsTabPage;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel InsertedTableLayoutPanel;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumirationLabel;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.Label SeasonHandleLabel;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
    }
}

