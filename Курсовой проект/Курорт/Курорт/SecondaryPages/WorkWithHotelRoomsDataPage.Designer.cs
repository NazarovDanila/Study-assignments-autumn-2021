
namespace Курорт.Pages
{
    partial class WorkWithHotelRoomsDataPage
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
            System.Windows.Forms.Label howManyPeopleLabel;
            System.Windows.Forms.Label roomIDLabel;
            System.Windows.Forms.Label roomPriceLabel;
            this.CloseButton = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.howManyPeopleTextBox = new System.Windows.Forms.TextBox();
            this.hotelRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            howManyPeopleLabel = new System.Windows.Forms.Label();
            roomIDLabel = new System.Windows.Forms.Label();
            roomPriceLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // howManyPeopleLabel
            // 
            howManyPeopleLabel.AutoSize = true;
            howManyPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            howManyPeopleLabel.ForeColor = System.Drawing.SystemColors.Window;
            howManyPeopleLabel.Location = new System.Drawing.Point(97, 218);
            howManyPeopleLabel.Name = "howManyPeopleLabel";
            howManyPeopleLabel.Size = new System.Drawing.Size(123, 20);
            howManyPeopleLabel.TabIndex = 84;
            howManyPeopleLabel.Text = "Вместимость";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            roomIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            roomIDLabel.Location = new System.Drawing.Point(156, 168);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new System.Drawing.Size(64, 20);
            roomIDLabel.TabIndex = 88;
            roomIDLabel.Text = "Номер";
            // 
            // roomPriceLabel
            // 
            roomPriceLabel.AutoSize = true;
            roomPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            roomPriceLabel.ForeColor = System.Drawing.SystemColors.Window;
            roomPriceLabel.Location = new System.Drawing.Point(118, 270);
            roomPriceLabel.Name = "roomPriceLabel";
            roomPriceLabel.Size = new System.Drawing.Size(102, 20);
            roomPriceLabel.TabIndex = 90;
            roomPriceLabel.Text = "Стоимость";
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(howManyPeopleLabel);
            this.panel1.Controls.Add(this.howManyPeopleTextBox);
            this.panel1.Controls.Add(roomIDLabel);
            this.panel1.Controls.Add(this.roomIDTextBox);
            this.panel1.Controls.Add(roomPriceLabel);
            this.panel1.Controls.Add(this.roomPriceTextBox);
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
            // howManyPeopleTextBox
            // 
            this.howManyPeopleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelRoomsBindingSource, "HowManyPeople", true));
            this.howManyPeopleTextBox.Location = new System.Drawing.Point(239, 218);
            this.howManyPeopleTextBox.Name = "howManyPeopleTextBox";
            this.howManyPeopleTextBox.Size = new System.Drawing.Size(324, 22);
            this.howManyPeopleTextBox.TabIndex = 85;
            // 
            // hotelRoomsBindingSource
            // 
            this.hotelRoomsBindingSource.DataSource = typeof(Курорт.ModelEF.HotelRooms);
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelRoomsBindingSource, "RoomID", true));
            this.roomIDTextBox.Location = new System.Drawing.Point(239, 168);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.roomIDTextBox.TabIndex = 89;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelRoomsBindingSource, "RoomPrice", true));
            this.roomPriceTextBox.Location = new System.Drawing.Point(239, 270);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(324, 22);
            this.roomPriceTextBox.TabIndex = 91;
            // 
            // WorkWithHotelRoomsDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.panel1);
            this.Name = "WorkWithHotelRoomsDataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithHotelRoomsDataPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox howManyPeopleTextBox;
        private System.Windows.Forms.BindingSource hotelRoomsBindingSource;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.TextBox roomPriceTextBox;
    }
}