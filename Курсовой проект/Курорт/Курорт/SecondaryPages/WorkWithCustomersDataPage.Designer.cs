
namespace Курорт.SecondaryPages
{
    partial class WorkWithCustomersDataPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerSurnameTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            customerIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            customerIDLabel.Location = new System.Drawing.Point(185, 143);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(26, 20);
            customerIDLabel.TabIndex = 86;
            customerIDLabel.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.PageNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 75);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(629, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PageNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageNameLabel.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.PageNameLabel.Location = new System.Drawing.Point(0, 0);
            this.PageNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(676, 75);
            this.PageNameLabel.TabIndex = 0;
            this.PageNameLabel.Text = "PageNameLabel";
            this.PageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.SystemColors.Window;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SaveChangesButton.Location = new System.Drawing.Point(216, 394);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(242, 54);
            this.SaveChangesButton.TabIndex = 3;
            this.SaveChangesButton.Text = "СОХРАНИТЬ";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.PhoneNumberLabel);
            this.panel1.Controls.Add(this.PatronymicLabel);
            this.panel1.Controls.Add(this.FirstNameLabel);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(customerIDLabel);
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.customerPatronymicTextBox);
            this.panel1.Controls.Add(this.customerPhoneNumberTextBox);
            this.panel1.Controls.Add(this.customerSurnameTextBox);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 472);
            this.panel1.TabIndex = 8;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(56, 313);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(155, 20);
            this.PhoneNumberLabel.TabIndex = 99;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PatronymicLabel.Location = new System.Drawing.Point(120, 266);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(91, 20);
            this.PatronymicLabel.TabIndex = 98;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.FirstNameLabel.Location = new System.Drawing.Point(169, 223);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(42, 20);
            this.FirstNameLabel.TabIndex = 97;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.LastNameLabel.Location = new System.Drawing.Point(124, 182);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(87, 20);
            this.LastNameLabel.TabIndex = 96;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(230, 143);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerIDTextBox.TabIndex = 87;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Курорт.ModelEF.Customers);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(230, 223);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerNameTextBox.TabIndex = 89;
            // 
            // customerPatronymicTextBox
            // 
            this.customerPatronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerPatronymic", true));
            this.customerPatronymicTextBox.Location = new System.Drawing.Point(230, 266);
            this.customerPatronymicTextBox.Name = "customerPatronymicTextBox";
            this.customerPatronymicTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerPatronymicTextBox.TabIndex = 91;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerPhoneNumber", true));
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(230, 310);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerPhoneNumberTextBox.TabIndex = 93;
            // 
            // customerSurnameTextBox
            // 
            this.customerSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerSurname", true));
            this.customerSurnameTextBox.Location = new System.Drawing.Point(230, 182);
            this.customerSurnameTextBox.Name = "customerSurnameTextBox";
            this.customerSurnameTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerSurnameTextBox.TabIndex = 95;
            // 
            // WorkWithCustomersDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.panel1);
            this.Name = "WorkWithCustomersDataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithCustomersDataPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerPatronymicTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox customerSurnameTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
    }
}