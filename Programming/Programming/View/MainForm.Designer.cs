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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.EnumsMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnumsInsertedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.SeasonsControl = new Programming.View.Controls.SeasonsControl();
            this.WeekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.AllEnumerationsControl = new Programming.View.Controls.AllEnumerationsControl();
            this.RectanglesControl = new Programming.View.Controls.RectanglesControl();
            this.MoviesControl = new Programming.View.Controls.MoviesControl();
            this.RectanglesCollisionControl = new Programming.View.Controls.RectanglesCollisionControl();
            this.TabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsMainTableLayoutPanel.SuspendLayout();
            this.EnumsInsertedTableLayoutPanel.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.EnumsMainTableLayoutPanel);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 424);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumsMainTableLayoutPanel
            // 
            this.EnumsMainTableLayoutPanel.ColumnCount = 1;
            this.EnumsMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnumsMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EnumsMainTableLayoutPanel.Controls.Add(this.EnumsInsertedTableLayoutPanel, 0, 1);
            this.EnumsMainTableLayoutPanel.Controls.Add(this.AllEnumerationsControl, 0, 0);
            this.EnumsMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsMainTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnumsMainTableLayoutPanel.Name = "EnumsMainTableLayoutPanel";
            this.EnumsMainTableLayoutPanel.RowCount = 2;
            this.EnumsMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsMainTableLayoutPanel.Size = new System.Drawing.Size(786, 418);
            this.EnumsMainTableLayoutPanel.TabIndex = 3;
            // 
            // EnumsInsertedTableLayoutPanel
            // 
            this.EnumsInsertedTableLayoutPanel.ColumnCount = 2;
            this.EnumsInsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsInsertedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsInsertedTableLayoutPanel.Controls.Add(this.SeasonsControl, 1, 0);
            this.EnumsInsertedTableLayoutPanel.Controls.Add(this.WeekdayParsingControl, 0, 0);
            this.EnumsInsertedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsInsertedTableLayoutPanel.Location = new System.Drawing.Point(0, 209);
            this.EnumsInsertedTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumsInsertedTableLayoutPanel.Name = "EnumsInsertedTableLayoutPanel";
            this.EnumsInsertedTableLayoutPanel.RowCount = 1;
            this.EnumsInsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnumsInsertedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.EnumsInsertedTableLayoutPanel.Size = new System.Drawing.Size(786, 209);
            this.EnumsInsertedTableLayoutPanel.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 424);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesControl, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.MoviesControl, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(792, 424);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 424);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonsControl
            // 
            this.SeasonsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonsControl.Location = new System.Drawing.Point(396, 3);
            this.SeasonsControl.Name = "SeasonsControl";
            this.SeasonsControl.Size = new System.Drawing.Size(387, 203);
            this.SeasonsControl.TabIndex = 1;
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingControl.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(387, 203);
            this.WeekdayParsingControl.TabIndex = 2;
            // 
            // AllEnumerationsControl
            // 
            this.AllEnumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllEnumerationsControl.Location = new System.Drawing.Point(3, 3);
            this.AllEnumerationsControl.Name = "AllEnumerationsControl";
            this.AllEnumerationsControl.Size = new System.Drawing.Size(780, 203);
            this.AllEnumerationsControl.TabIndex = 1;
            // 
            // RectanglesControl
            // 
            this.RectanglesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesControl.Name = "RectanglesControl";
            this.RectanglesControl.Size = new System.Drawing.Size(390, 418);
            this.RectanglesControl.TabIndex = 2;
            // 
            // MoviesControl
            // 
            this.MoviesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesControl.Location = new System.Drawing.Point(399, 3);
            this.MoviesControl.Name = "MoviesControl";
            this.MoviesControl.Size = new System.Drawing.Size(390, 418);
            this.MoviesControl.TabIndex = 3;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(792, 424);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsMainTableLayoutPanel.ResumeLayout(false);
            this.EnumsInsertedTableLayoutPanel.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TableLayoutPanel EnumsMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel EnumsInsertedTableLayoutPanel;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TableLayoutPanel ClassesTableLayoutPanel;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Controls.RectanglesCollisionControl RectanglesCollisionControl;
        private Controls.AllEnumerationsControl AllEnumerationsControl;
        private Controls.SeasonsControl SeasonsControl;
        private Controls.WeekdayParsingControl WeekdayParsingControl;
        private Controls.RectanglesControl RectanglesControl;
        private Controls.MoviesControl MoviesControl;
    }
}

