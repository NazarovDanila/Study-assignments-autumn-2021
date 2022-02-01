
namespace Курорт.Pages
{
    partial class FoodTypePage
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
            this.DelDataButton = new System.Windows.Forms.Button();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.foodTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.DelDataButton);
            this.panel1.Controls.Add(this.ChangeDataButton);
            this.panel1.Controls.Add(this.AddDataButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 537);
            this.panel1.TabIndex = 6;
            // 
            // DelDataButton
            // 
            this.DelDataButton.BackColor = System.Drawing.SystemColors.Window;
            this.DelDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelDataButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.DelDataButton.Location = new System.Drawing.Point(728, 467);
            this.DelDataButton.Name = "DelDataButton";
            this.DelDataButton.Size = new System.Drawing.Size(242, 54);
            this.DelDataButton.TabIndex = 5;
            this.DelDataButton.Text = "УДАЛИТЬ";
            this.DelDataButton.UseVisualStyleBackColor = false;
            this.DelDataButton.Click += new System.EventHandler(this.DelDataButton_Click);
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.BackColor = System.Drawing.SystemColors.Window;
            this.ChangeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDataButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ChangeDataButton.Location = new System.Drawing.Point(385, 467);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(242, 54);
            this.ChangeDataButton.TabIndex = 4;
            this.ChangeDataButton.Text = "ИЗМЕНИТЬ";
            this.ChangeDataButton.UseVisualStyleBackColor = false;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDataButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddDataButton.Location = new System.Drawing.Point(45, 467);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(242, 54);
            this.AddDataButton.TabIndex = 3;
            this.AddDataButton.Text = "ДОБАВИТЬ";
            this.AddDataButton.UseVisualStyleBackColor = false;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodTypeIDDataGridViewTextBoxColumn,
            this.foodTypeNameDataGridViewTextBoxColumn,
            this.foodTypePriceDataGridViewTextBoxColumn,
            this.foodTypeDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foodTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // foodTypesBindingSource
            // 
            this.foodTypesBindingSource.DataSource = typeof(Курорт.ModelEF.FoodTypes);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 75);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(979, 9);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(1018, 75);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Типы питания";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodTypeIDDataGridViewTextBoxColumn
            // 
            this.foodTypeIDDataGridViewTextBoxColumn.DataPropertyName = "FoodTypeID";
            this.foodTypeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.foodTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodTypeIDDataGridViewTextBoxColumn.Name = "foodTypeIDDataGridViewTextBoxColumn";
            this.foodTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodTypeNameDataGridViewTextBoxColumn
            // 
            this.foodTypeNameDataGridViewTextBoxColumn.DataPropertyName = "FoodTypeName";
            this.foodTypeNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.foodTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodTypeNameDataGridViewTextBoxColumn.Name = "foodTypeNameDataGridViewTextBoxColumn";
            this.foodTypeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodTypePriceDataGridViewTextBoxColumn
            // 
            this.foodTypePriceDataGridViewTextBoxColumn.DataPropertyName = "FoodTypePrice";
            this.foodTypePriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.foodTypePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodTypePriceDataGridViewTextBoxColumn.Name = "foodTypePriceDataGridViewTextBoxColumn";
            this.foodTypePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.foodTypeDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodTypeDescription";
            this.foodTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.foodTypeDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodTypeDescriptionDataGridViewTextBoxColumn.Name = "foodTypeDescriptionDataGridViewTextBoxColumn";
            // 
            // FoodTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 537);
            this.Controls.Add(this.panel1);
            this.Name = "FoodTypePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FoodTypePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DelDataButton;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.BindingSource foodTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeDescriptionDataGridViewTextBoxColumn;
    }
}