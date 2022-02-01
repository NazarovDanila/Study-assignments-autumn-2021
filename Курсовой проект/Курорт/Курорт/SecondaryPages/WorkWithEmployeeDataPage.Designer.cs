
namespace Курорт.SecondaryPages
{
    partial class WorkWithEmployeeDataPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.postIDTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(this.phone_numberTextBox);
            this.panel1.Controls.Add(this.postIDTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.PhoneNumberLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PatronymicLabel);
            this.panel1.Controls.Add(this.PostLabel);
            this.panel1.Controls.Add(this.FirstNameLabel);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.LoginLabel);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 472);
            this.panel1.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(239, 107);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(324, 22);
            this.loginTextBox.TabIndex = 84;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataSource = typeof(Курорт.ModelEF.Employees);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(239, 221);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(324, 22);
            this.nameTextBox.TabIndex = 86;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(239, 142);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(324, 22);
            this.passwordTextBox.TabIndex = 88;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(239, 260);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(324, 22);
            this.patronymicTextBox.TabIndex = 90;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(239, 340);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(324, 22);
            this.phone_numberTextBox.TabIndex = 92;
            // 
            // postIDTextBox
            // 
            this.postIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "PostID", true));
            this.postIDTextBox.Location = new System.Drawing.Point(239, 300);
            this.postIDTextBox.Name = "postIDTextBox";
            this.postIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.postIDTextBox.TabIndex = 94;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource1, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(239, 183);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(324, 22);
            this.surnameTextBox.TabIndex = 96;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(65, 340);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(155, 20);
            this.PhoneNumberLabel.TabIndex = 81;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(148, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Пароль";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PatronymicLabel.Location = new System.Drawing.Point(129, 262);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(91, 20);
            this.PatronymicLabel.TabIndex = 72;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PostLabel.Location = new System.Drawing.Point(117, 300);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(103, 20);
            this.PostLabel.TabIndex = 77;
            this.PostLabel.Text = "Должность";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.FirstNameLabel.Location = new System.Drawing.Point(174, 224);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(42, 20);
            this.FirstNameLabel.TabIndex = 71;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.LastNameLabel.Location = new System.Drawing.Point(133, 185);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(87, 20);
            this.LastNameLabel.TabIndex = 70;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginLabel.Location = new System.Drawing.Point(161, 109);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(59, 20);
            this.LoginLabel.TabIndex = 76;
            this.LoginLabel.Text = "Логин";
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
            // WorkWithEmployeeDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.panel1);
            this.Name = "WorkWithEmployeeDataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithEmployeeDataPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox postIDTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
    }
}