
namespace Курорт.Pages
{
    partial class AdministratorHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.OpenRequestsButton = new System.Windows.Forms.Button();
            this.OpenFoodTypeButton = new System.Windows.Forms.Button();
            this.OpenHotelRoomsButton = new System.Windows.Forms.Button();
            this.OpenEmployeesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenCustomersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.OpenCustomersButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.OpenRequestsButton);
            this.panel1.Controls.Add(this.OpenFoodTypeButton);
            this.panel1.Controls.Add(this.OpenHotelRoomsButton);
            this.panel1.Controls.Add(this.OpenEmployeesButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 613);
            this.panel1.TabIndex = 4;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.SystemColors.Window;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.LogOutButton.Location = new System.Drawing.Point(106, 497);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(242, 81);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "ВЫХОД ИЗ АККАУНТА";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // OpenRequestsButton
            // 
            this.OpenRequestsButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenRequestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenRequestsButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenRequestsButton.Location = new System.Drawing.Point(106, 420);
            this.OpenRequestsButton.Name = "OpenRequestsButton";
            this.OpenRequestsButton.Size = new System.Drawing.Size(242, 54);
            this.OpenRequestsButton.TabIndex = 4;
            this.OpenRequestsButton.Text = "ЗАЯВКИ";
            this.OpenRequestsButton.UseVisualStyleBackColor = false;
            this.OpenRequestsButton.Click += new System.EventHandler(this.OpenRequestsButton_Click);
            // 
            // OpenFoodTypeButton
            // 
            this.OpenFoodTypeButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenFoodTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFoodTypeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenFoodTypeButton.Location = new System.Drawing.Point(106, 342);
            this.OpenFoodTypeButton.Name = "OpenFoodTypeButton";
            this.OpenFoodTypeButton.Size = new System.Drawing.Size(242, 54);
            this.OpenFoodTypeButton.TabIndex = 3;
            this.OpenFoodTypeButton.Text = "ТИПЫ ПИТАНИЯ";
            this.OpenFoodTypeButton.UseVisualStyleBackColor = false;
            this.OpenFoodTypeButton.Click += new System.EventHandler(this.OpenFoodTypeButton_Click);
            // 
            // OpenHotelRoomsButton
            // 
            this.OpenHotelRoomsButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenHotelRoomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenHotelRoomsButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenHotelRoomsButton.Location = new System.Drawing.Point(106, 265);
            this.OpenHotelRoomsButton.Name = "OpenHotelRoomsButton";
            this.OpenHotelRoomsButton.Size = new System.Drawing.Size(242, 54);
            this.OpenHotelRoomsButton.TabIndex = 2;
            this.OpenHotelRoomsButton.Text = "НОМЕРА";
            this.OpenHotelRoomsButton.UseVisualStyleBackColor = false;
            this.OpenHotelRoomsButton.Click += new System.EventHandler(this.OpenHotelRoomsButton_Click);
            // 
            // OpenEmployeesButton
            // 
            this.OpenEmployeesButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenEmployeesButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenEmployeesButton.Location = new System.Drawing.Point(106, 110);
            this.OpenEmployeesButton.Name = "OpenEmployeesButton";
            this.OpenEmployeesButton.Size = new System.Drawing.Size(242, 54);
            this.OpenEmployeesButton.TabIndex = 1;
            this.OpenEmployeesButton.Text = "СОТРУДНИКИ";
            this.OpenEmployeesButton.UseVisualStyleBackColor = false;
            this.OpenEmployeesButton.Click += new System.EventHandler(this.OpenEmployeesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 75);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Администратор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenCustomersButton
            // 
            this.OpenCustomersButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenCustomersButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenCustomersButton.Location = new System.Drawing.Point(106, 185);
            this.OpenCustomersButton.Name = "OpenCustomersButton";
            this.OpenCustomersButton.Size = new System.Drawing.Size(242, 54);
            this.OpenCustomersButton.TabIndex = 6;
            this.OpenCustomersButton.Text = "ПОСЕТИТЕЛИ";
            this.OpenCustomersButton.UseVisualStyleBackColor = false;
            this.OpenCustomersButton.Click += new System.EventHandler(this.OpenCustomersButton_Click);
            // 
            // AdministratorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 613);
            this.Controls.Add(this.panel1);
            this.Name = "AdministratorHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button OpenRequestsButton;
        private System.Windows.Forms.Button OpenFoodTypeButton;
        private System.Windows.Forms.Button OpenHotelRoomsButton;
        private System.Windows.Forms.Button OpenEmployeesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenCustomersButton;
    }
}