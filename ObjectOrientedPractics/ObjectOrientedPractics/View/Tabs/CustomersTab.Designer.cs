﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(407, 28);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(158, 20);
            this.IdTextBox.TabIndex = 20;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(345, 31);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(345, 4);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomerLabel.TabIndex = 18;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(117, 556);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(108, 40);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 556);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 40);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 20);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(336, 530);
            this.CustomersListBox.TabIndex = 15;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 4);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 14;
            this.CustomersLabel.Text = "Customers";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(345, 60);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 22;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(407, 57);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(790, 20);
            this.FullNameTextBox.TabIndex = 25;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(407, 83);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.IsPriorityCheckBox.TabIndex = 27;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(345, 245);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(63, 13);
            this.DiscountsLabel.TabIndex = 28;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.IntegralHeight = false;
            this.DiscountsListBox.Location = new System.Drawing.Point(348, 261);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(332, 96);
            this.DiscountsListBox.TabIndex = 29;
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(686, 261);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(100, 36);
            this.AddDiscountButton.TabIndex = 30;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(686, 303);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(100, 36);
            this.RemoveDiscountButton.TabIndex = 31;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(342, 109);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(855, 133);
            this.AddressControl.TabIndex = 26;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveDiscountButton);
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.IsPriorityCheckBox);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1200, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button RemoveDiscountButton;
    }
}
