namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.CounrtyLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(102, 13);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(3, 19);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(60, 13);
            this.IndexLabel.TabIndex = 1;
            this.IndexLabel.Text = "Post Index:";
            // 
            // CounrtyLabel
            // 
            this.CounrtyLabel.AutoSize = true;
            this.CounrtyLabel.Location = new System.Drawing.Point(3, 45);
            this.CounrtyLabel.Name = "CounrtyLabel";
            this.CounrtyLabel.Size = new System.Drawing.Size(46, 13);
            this.CounrtyLabel.TabIndex = 2;
            this.CounrtyLabel.Text = "Counrty:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 73);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 99);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(175, 99);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.ApartmentLabel.TabIndex = 5;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(289, 45);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City:";
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Location = new System.Drawing.Point(69, 16);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(121, 20);
            this.IndexTextBox.TabIndex = 7;
            this.IndexTextBox.TextChanged += new System.EventHandler(this.IndexTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(69, 42);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(214, 20);
            this.CountryTextBox.TabIndex = 8;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Location = new System.Drawing.Point(69, 70);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(499, 20);
            this.StreetTextBox.TabIndex = 9;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(69, 96);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuildingTextBox.TabIndex = 10;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(239, 96);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApartmentTextBox.TabIndex = 11;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(322, 42);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(246, 20);
            this.CityTextBox.TabIndex = 12;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.IndexTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CounrtyLabel);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(571, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Label CounrtyLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
    }
}
