
namespace Курорт.Pages
{
    partial class WorkWithRequestsDataPage
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
            System.Windows.Forms.Label check_inDateLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label evictionDateLabel;
            System.Windows.Forms.Label foodTypeIDLabel;
            System.Windows.Forms.Label loginLabel1;
            System.Windows.Forms.Label requestIDLabel;
            System.Windows.Forms.Label roomIDLabel;
            System.Windows.Forms.Label totalСostLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_inDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.evictionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.foodTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox1 = new System.Windows.Forms.TextBox();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.totalСostTextBox = new System.Windows.Forms.TextBox();
            check_inDateLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            evictionDateLabel = new System.Windows.Forms.Label();
            foodTypeIDLabel = new System.Windows.Forms.Label();
            loginLabel1 = new System.Windows.Forms.Label();
            requestIDLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            totalСostLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // check_inDateLabel
            // 
            check_inDateLabel.AutoSize = true;
            check_inDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            check_inDateLabel.ForeColor = System.Drawing.SystemColors.Window;
            check_inDateLabel.Location = new System.Drawing.Point(90, 344);
            check_inDateLabel.Name = "check_inDateLabel";
            check_inDateLabel.Size = new System.Drawing.Size(145, 20);
            check_inDateLabel.TabIndex = 84;
            check_inDateLabel.Text = "Дата заселения";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            customerIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            customerIDLabel.Location = new System.Drawing.Point(135, 195);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(100, 20);
            customerIDLabel.TabIndex = 86;
            customerIDLabel.Text = "ID клиента";
            // 
            // evictionDateLabel
            // 
            evictionDateLabel.AutoSize = true;
            evictionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            evictionDateLabel.ForeColor = System.Drawing.SystemColors.Window;
            evictionDateLabel.Location = new System.Drawing.Point(87, 391);
            evictionDateLabel.Name = "evictionDateLabel";
            evictionDateLabel.Size = new System.Drawing.Size(148, 20);
            evictionDateLabel.TabIndex = 88;
            evictionDateLabel.Text = "Дата выселения";
            // 
            // foodTypeIDLabel
            // 
            foodTypeIDLabel.AutoSize = true;
            foodTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            foodTypeIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            foodTypeIDLabel.Location = new System.Drawing.Point(89, 292);
            foodTypeIDLabel.Name = "foodTypeIDLabel";
            foodTypeIDLabel.Size = new System.Drawing.Size(146, 20);
            foodTypeIDLabel.TabIndex = 90;
            foodTypeIDLabel.Text = "ID типа питания";
            // 
            // loginLabel1
            // 
            loginLabel1.AutoSize = true;
            loginLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            loginLabel1.ForeColor = System.Drawing.SystemColors.Window;
            loginLabel1.Location = new System.Drawing.Point(73, 149);
            loginLabel1.Name = "loginLabel1";
            loginLabel1.Size = new System.Drawing.Size(162, 20);
            loginLabel1.TabIndex = 92;
            loginLabel1.Text = "Логин сотрудника";
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            requestIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            requestIDLabel.Location = new System.Drawing.Point(136, 105);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(99, 20);
            requestIDLabel.TabIndex = 94;
            requestIDLabel.Text = "ID запроса";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            roomIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            roomIDLabel.Location = new System.Drawing.Point(171, 244);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(64, 20);
            roomIDLabel.TabIndex = 96;
            roomIDLabel.Text = "Номер";
            // 
            // totalСostLabel
            // 
            totalСostLabel.AutoSize = true;
            totalСostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            totalСostLabel.ForeColor = System.Drawing.SystemColors.Window;
            totalСostLabel.Location = new System.Drawing.Point(52, 435);
            totalСostLabel.Name = "totalСostLabel";
            totalСostLabel.Size = new System.Drawing.Size(183, 20);
            totalСostLabel.TabIndex = 98;
            totalСostLabel.Text = "Итоговая стоимость";
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
            this.panel2.Size = new System.Drawing.Size(669, 75);
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
            this.PageNameLabel.Size = new System.Drawing.Size(669, 75);
            this.PageNameLabel.TabIndex = 0;
            this.PageNameLabel.Text = "PageNameLabel";
            this.PageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.SystemColors.Window;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SaveChangesButton.Location = new System.Drawing.Point(211, 483);
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
            this.panel1.Controls.Add(check_inDateLabel);
            this.panel1.Controls.Add(this.check_inDateDateTimePicker);
            this.panel1.Controls.Add(customerIDLabel);
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Controls.Add(evictionDateLabel);
            this.panel1.Controls.Add(this.evictionDateDateTimePicker);
            this.panel1.Controls.Add(foodTypeIDLabel);
            this.panel1.Controls.Add(this.foodTypeIDTextBox);
            this.panel1.Controls.Add(loginLabel1);
            this.panel1.Controls.Add(this.loginTextBox1);
            this.panel1.Controls.Add(requestIDLabel);
            this.panel1.Controls.Add(this.requestIDTextBox);
            this.panel1.Controls.Add(roomIDLabel);
            this.panel1.Controls.Add(this.roomIDTextBox);
            this.panel1.Controls.Add(totalСostLabel);
            this.panel1.Controls.Add(this.totalСostTextBox);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 560);
            this.panel1.TabIndex = 8;
            // 
            // check_inDateDateTimePicker
            // 
            this.check_inDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestsBindingSource, "Check_inDate", true));
            this.check_inDateDateTimePicker.Location = new System.Drawing.Point(254, 342);
            this.check_inDateDateTimePicker.Name = "check_inDateDateTimePicker";
            this.check_inDateDateTimePicker.Size = new System.Drawing.Size(324, 22);
            this.check_inDateDateTimePicker.TabIndex = 85;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataSource = typeof(Курорт.ModelEF.Requests);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(254, 195);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.customerIDTextBox.TabIndex = 87;
            // 
            // evictionDateDateTimePicker
            // 
            this.evictionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestsBindingSource, "EvictionDate", true));
            this.evictionDateDateTimePicker.Location = new System.Drawing.Point(254, 389);
            this.evictionDateDateTimePicker.Name = "evictionDateDateTimePicker";
            this.evictionDateDateTimePicker.Size = new System.Drawing.Size(324, 22);
            this.evictionDateDateTimePicker.TabIndex = 89;
            // 
            // foodTypeIDTextBox
            // 
            this.foodTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "FoodTypeID", true));
            this.foodTypeIDTextBox.Location = new System.Drawing.Point(254, 292);
            this.foodTypeIDTextBox.Name = "foodTypeIDTextBox";
            this.foodTypeIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.foodTypeIDTextBox.TabIndex = 91;
            // 
            // loginTextBox1
            // 
            this.loginTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Login", true));
            this.loginTextBox1.Location = new System.Drawing.Point(254, 149);
            this.loginTextBox1.Name = "loginTextBox1";
            this.loginTextBox1.Size = new System.Drawing.Size(324, 22);
            this.loginTextBox1.TabIndex = 93;
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "RequestID", true));
            this.requestIDTextBox.Location = new System.Drawing.Point(254, 105);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.requestIDTextBox.TabIndex = 95;
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "RoomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(254, 244);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.roomIDTextBox.TabIndex = 97;
            // 
            // totalСostTextBox
            // 
            this.totalСostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "TotalСost", true));
            this.totalСostTextBox.Location = new System.Drawing.Point(254, 435);
            this.totalСostTextBox.Name = "totalСostTextBox";
            this.totalСostTextBox.Size = new System.Drawing.Size(324, 22);
            this.totalСostTextBox.TabIndex = 99;
            // 
            // WorkWithRequestsDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(669, 560);
            this.Controls.Add(this.panel1);
            this.Name = "WorkWithRequestsDataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithRequestsDataPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private System.Windows.Forms.DateTimePicker check_inDateDateTimePicker;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DateTimePicker evictionDateDateTimePicker;
        private System.Windows.Forms.TextBox foodTypeIDTextBox;
        private System.Windows.Forms.TextBox loginTextBox1;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.TextBox totalСostTextBox;
    }
}