namespace Programming.View
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
            this.EnumerationMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnumerationInsertedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayAnswerLable = new System.Windows.Forms.Label();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleLabel = new System.Windows.Forms.Label();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumirationLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.CenterGroupBox = new System.Windows.Forms.GroupBox();
            this.YCenterTextBox = new System.Windows.Forms.TextBox();
            this.YCenterLabel = new System.Windows.Forms.Label();
            this.XCenterLabel = new System.Windows.Forms.Label();
            this.XCenterTextBox = new System.Windows.Forms.TextBox();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieButton = new System.Windows.Forms.Button();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationInMinutesLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.TabControl.SuspendLayout();
            this.EnumerationsTabPage.SuspendLayout();
            this.EnumerationMainTableLayoutPanel.SuspendLayout();
            this.EnumerationInsertedTableLayoutPanel.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesMainTableLayoutPanel.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.CenterGroupBox.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumerationsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // EnumerationsTabPage
            // 
            this.EnumerationsTabPage.Controls.Add(this.EnumerationMainTableLayoutPanel);
            this.EnumerationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationsTabPage.Name = "EnumerationsTabPage";
            this.EnumerationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationsTabPage.Size = new System.Drawing.Size(792, 424);
            this.EnumerationsTabPage.TabIndex = 0;
            this.EnumerationsTabPage.Text = "Enums";
            this.EnumerationsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationMainTableLayoutPanel
            // 
            this.EnumerationMainTableLayoutPanel.ColumnCount = 1;
            this.EnumerationMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnumerationMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EnumerationMainTableLayoutPanel.Controls.Add(this.EnumerationInsertedTableLayoutPanel, 0, 1);
            this.EnumerationMainTableLayoutPanel.Controls.Add(this.EnumerationsGroupBox, 0, 0);
            this.EnumerationMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationMainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnumerationMainTableLayoutPanel.Name = "EnumerationMainTableLayoutPanel";
            this.EnumerationMainTableLayoutPanel.RowCount = 2;
            this.EnumerationMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationMainTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.EnumerationMainTableLayoutPanel.TabIndex = 3;
            // 
            // EnumerationInsertedTableLayoutPanel
            // 
            this.EnumerationInsertedTableLayoutPanel.ColumnCount = 2;
            this.EnumerationInsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationInsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumerationInsertedTableLayoutPanel.Controls.Add(this.WeekdayParsingGroupBox, 0, 0);
            this.EnumerationInsertedTableLayoutPanel.Controls.Add(this.SeasonHandleGroupBox, 1, 0);
            this.EnumerationInsertedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumerationInsertedTableLayoutPanel.Location = new System.Drawing.Point(0, 209);
            this.EnumerationInsertedTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumerationInsertedTableLayoutPanel.Name = "EnumerationInsertedTableLayoutPanel";
            this.EnumerationInsertedTableLayoutPanel.RowCount = 1;
            this.EnumerationInsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnumerationInsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.EnumerationInsertedTableLayoutPanel.Size = new System.Drawing.Size(786, 209);
            this.EnumerationInsertedTableLayoutPanel.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayAnswerLable);
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
            // WeekdayAnswerLable
            // 
            this.WeekdayAnswerLable.AutoSize = true;
            this.WeekdayAnswerLable.Location = new System.Drawing.Point(6, 77);
            this.WeekdayAnswerLable.Name = "WeekdayAnswerLable";
            this.WeekdayAnswerLable.Size = new System.Drawing.Size(115, 13);
            this.WeekdayAnswerLable.TabIndex = 3;
            this.WeekdayAnswerLable.Text = "Введите день недели";
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(215, 41);
            this.WeekdayParsingButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 25);
            this.WeekdayParsingButton.TabIndex = 2;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(9, 44);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(200, 20);
            this.WeekdayParsingTextBox.TabIndex = 1;
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
            // SeasonHandleLabel
            // 
            this.SeasonHandleLabel.AutoSize = true;
            this.SeasonHandleLabel.Location = new System.Drawing.Point(3, 27);
            this.SeasonHandleLabel.Name = "SeasonHandleLabel";
            this.SeasonHandleLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonHandleLabel.TabIndex = 2;
            this.SeasonHandleLabel.Text = "Choose season:";
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(133, 41);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 25);
            this.SeasonHandleButton.TabIndex = 1;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(6, 43);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonHandleComboBox.TabIndex = 0;
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
            // EnumirationLabel
            // 
            this.EnumirationLabel.AutoSize = true;
            this.EnumirationLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumirationLabel.Name = "EnumirationLabel";
            this.EnumirationLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumirationLabel.TabIndex = 3;
            this.EnumirationLabel.Text = "Choose enumeration:";
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
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesMainTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 424);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesMainTableLayoutPanel
            // 
            this.ClassesMainTableLayoutPanel.ColumnCount = 2;
            this.ClassesMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesMainTableLayoutPanel.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.ClassesMainTableLayoutPanel.Controls.Add(this.MoviesGroupBox, 1, 0);
            this.ClassesMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesMainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ClassesMainTableLayoutPanel.Name = "ClassesMainTableLayoutPanel";
            this.ClassesMainTableLayoutPanel.RowCount = 1;
            this.ClassesMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ClassesMainTableLayoutPanel.Size = new System.Drawing.Size(792, 424);
            this.ClassesMainTableLayoutPanel.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.CenterGroupBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(390, 418);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
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
            this.RectangleButton.Location = new System.Drawing.Point(132, 248);
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
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(132, 35);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(150, 20);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
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
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(129, 19);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
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
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieButton);
            this.MoviesGroupBox.Controls.Add(this.RateTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationInMinutesTextBox);
            this.MoviesGroupBox.Controls.Add(this.TitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.RateLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.YearLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationInMinutesLabel);
            this.MoviesGroupBox.Controls.Add(this.TitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(399, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(390, 418);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(132, 217);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(75, 25);
            this.MovieButton.TabIndex = 11;
            this.MovieButton.Text = "Find";
            this.MovieButton.UseVisualStyleBackColor = true;
            this.MovieButton.Click += new System.EventHandler(this.MovieButton_Click);
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(132, 191);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(150, 20);
            this.RateTextBox.TabIndex = 10;
            this.RateTextBox.TextChanged += new System.EventHandler(this.RateTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(132, 152);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(150, 20);
            this.GenreTextBox.TabIndex = 9;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(132, 113);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(150, 20);
            this.YearTextBox.TabIndex = 8;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(132, 74);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(150, 20);
            this.DurationInMinutesTextBox.TabIndex = 7;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(132, 35);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(150, 20);
            this.TitleTextBox.TabIndex = 6;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(129, 175);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(33, 13);
            this.RateLabel.TabIndex = 5;
            this.RateLabel.Text = "Rate:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(129, 136);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(129, 97);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 13);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "Year:";
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(129, 58);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(100, 13);
            this.DurationInMinutesLabel.TabIndex = 2;
            this.DurationInMinutesLabel.Text = "Duration in minutes:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(129, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.IntegralHeight = false;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(120, 393);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
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
            this.EnumerationMainTableLayoutPanel.ResumeLayout(false);
            this.EnumerationInsertedTableLayoutPanel.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesMainTableLayoutPanel.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.CenterGroupBox.ResumeLayout(false);
            this.CenterGroupBox.PerformLayout();
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumerationsTabPage;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.TableLayoutPanel EnumerationMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel EnumerationInsertedTableLayoutPanel;
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
        private System.Windows.Forms.Label WeekdayAnswerLable;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TableLayoutPanel ClassesMainTableLayoutPanel;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DurationInMinutesLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox DurationInMinutesTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.GroupBox CenterGroupBox;
        private System.Windows.Forms.TextBox YCenterTextBox;
        private System.Windows.Forms.Label YCenterLabel;
        private System.Windows.Forms.Label XCenterLabel;
        private System.Windows.Forms.TextBox XCenterTextBox;
    }
}

