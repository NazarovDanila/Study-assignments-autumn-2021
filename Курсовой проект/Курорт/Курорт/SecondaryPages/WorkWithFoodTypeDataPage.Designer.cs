
namespace Курорт.Pages
{
    partial class WorkWithFoodTypeDataPage
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
            System.Windows.Forms.Label foodTypeDescriptionLabel;
            System.Windows.Forms.Label foodTypeIDLabel;
            System.Windows.Forms.Label foodTypeNameLabel;
            System.Windows.Forms.Label foodTypePriceLabel;
            this.CloseButton = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.foodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.foodTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.foodTypePriceTextBox = new System.Windows.Forms.TextBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            foodTypeDescriptionLabel = new System.Windows.Forms.Label();
            foodTypeIDLabel = new System.Windows.Forms.Label();
            foodTypeNameLabel = new System.Windows.Forms.Label();
            foodTypePriceLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodTypeDescriptionLabel
            // 
            foodTypeDescriptionLabel.AutoSize = true;
            foodTypeDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            foodTypeDescriptionLabel.ForeColor = System.Drawing.SystemColors.Window;
            foodTypeDescriptionLabel.Location = new System.Drawing.Point(129, 319);
            foodTypeDescriptionLabel.Name = "foodTypeDescriptionLabel";
            foodTypeDescriptionLabel.Size = new System.Drawing.Size(91, 20);
            foodTypeDescriptionLabel.TabIndex = 84;
            foodTypeDescriptionLabel.Text = "Описание";
            // 
            // foodTypeIDLabel
            // 
            foodTypeIDLabel.AutoSize = true;
            foodTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            foodTypeIDLabel.ForeColor = System.Drawing.SystemColors.Window;
            foodTypeIDLabel.Location = new System.Drawing.Point(194, 144);
            foodTypeIDLabel.Name = "foodTypeIDLabel";
            foodTypeIDLabel.Size = new System.Drawing.Size(26, 20);
            foodTypeIDLabel.TabIndex = 86;
            foodTypeIDLabel.Text = "ID";
            // 
            // foodTypeNameLabel
            // 
            foodTypeNameLabel.AutoSize = true;
            foodTypeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            foodTypeNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            foodTypeNameLabel.Location = new System.Drawing.Point(129, 199);
            foodTypeNameLabel.Name = "foodTypeNameLabel";
            foodTypeNameLabel.Size = new System.Drawing.Size(91, 20);
            foodTypeNameLabel.TabIndex = 88;
            foodTypeNameLabel.Text = "Название";
            // 
            // foodTypePriceLabel
            // 
            foodTypePriceLabel.AutoSize = true;
            foodTypePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            foodTypePriceLabel.ForeColor = System.Drawing.SystemColors.Window;
            foodTypePriceLabel.Location = new System.Drawing.Point(168, 258);
            foodTypePriceLabel.Name = "foodTypePriceLabel";
            foodTypePriceLabel.Size = new System.Drawing.Size(52, 20);
            foodTypePriceLabel.TabIndex = 90;
            foodTypePriceLabel.Text = "Цена";
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
            this.panel1.Controls.Add(foodTypeDescriptionLabel);
            this.panel1.Controls.Add(this.foodTypeDescriptionTextBox);
            this.panel1.Controls.Add(foodTypeIDLabel);
            this.panel1.Controls.Add(this.foodTypeIDTextBox);
            this.panel1.Controls.Add(foodTypeNameLabel);
            this.panel1.Controls.Add(this.foodTypeNameTextBox);
            this.panel1.Controls.Add(foodTypePriceLabel);
            this.panel1.Controls.Add(this.foodTypePriceTextBox);
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
            // foodTypeDescriptionTextBox
            // 
            this.foodTypeDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTypesBindingSource, "FoodTypeDescription", true));
            this.foodTypeDescriptionTextBox.Location = new System.Drawing.Point(239, 319);
            this.foodTypeDescriptionTextBox.Name = "foodTypeDescriptionTextBox";
            this.foodTypeDescriptionTextBox.Size = new System.Drawing.Size(324, 22);
            this.foodTypeDescriptionTextBox.TabIndex = 85;
            // 
            // foodTypesBindingSource
            // 
            this.foodTypesBindingSource.DataSource = typeof(Курорт.ModelEF.FoodTypes);
            // 
            // foodTypeIDTextBox
            // 
            this.foodTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTypesBindingSource, "FoodTypeID", true));
            this.foodTypeIDTextBox.Location = new System.Drawing.Point(239, 144);
            this.foodTypeIDTextBox.Name = "foodTypeIDTextBox";
            this.foodTypeIDTextBox.Size = new System.Drawing.Size(324, 22);
            this.foodTypeIDTextBox.TabIndex = 87;
            // 
            // foodTypeNameTextBox
            // 
            this.foodTypeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTypesBindingSource, "FoodTypeName", true));
            this.foodTypeNameTextBox.Location = new System.Drawing.Point(239, 199);
            this.foodTypeNameTextBox.Name = "foodTypeNameTextBox";
            this.foodTypeNameTextBox.Size = new System.Drawing.Size(324, 22);
            this.foodTypeNameTextBox.TabIndex = 89;
            // 
            // foodTypePriceTextBox
            // 
            this.foodTypePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodTypesBindingSource, "FoodTypePrice", true));
            this.foodTypePriceTextBox.Location = new System.Drawing.Point(239, 258);
            this.foodTypePriceTextBox.Name = "foodTypePriceTextBox";
            this.foodTypePriceTextBox.Size = new System.Drawing.Size(324, 22);
            this.foodTypePriceTextBox.TabIndex = 91;
            // 
            // WorkWithFoodTypeDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.panel1);
            this.Name = "WorkWithFoodTypeDataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithFoodTypeDataPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox foodTypeDescriptionTextBox;
        private System.Windows.Forms.BindingSource foodTypesBindingSource;
        private System.Windows.Forms.TextBox foodTypeIDTextBox;
        private System.Windows.Forms.TextBox foodTypeNameTextBox;
        private System.Windows.Forms.TextBox foodTypePriceTextBox;
    }
}