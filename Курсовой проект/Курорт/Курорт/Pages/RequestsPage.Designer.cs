
namespace Курорт.Pages
{
    partial class RequestsPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalСostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evictionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
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
            this.requestIDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.Login,
            this.customerIDDataGridViewTextBoxColumn,
            this.CustomerID,
            this.Column1,
            this.roomIDDataGridViewTextBoxColumn,
            this.foodTypeIDDataGridViewTextBoxColumn,
            this.checkinDateDataGridViewTextBoxColumn,
            this.evictionDateDataGridViewTextBoxColumn,
            this.totalСostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 335);
            this.dataGridView1.TabIndex = 1;
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
            this.NameLabel.Text = "Заявки";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(Курорт.ModelEF.Employees);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(Курорт.ModelEF.Customers);
            // 
            // foodTypesBindingSource
            // 
            this.foodTypesBindingSource.DataSource = typeof(Курорт.ModelEF.FoodTypes);
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataSource = typeof(Курорт.ModelEF.Requests);
            // 
            // totalСostDataGridViewTextBoxColumn
            // 
            this.totalСostDataGridViewTextBoxColumn.DataPropertyName = "TotalСost";
            this.totalСostDataGridViewTextBoxColumn.HeaderText = "Итоговая стоимость";
            this.totalСostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalСostDataGridViewTextBoxColumn.Name = "totalСostDataGridViewTextBoxColumn";
            this.totalСostDataGridViewTextBoxColumn.Width = 125;
            // 
            // evictionDateDataGridViewTextBoxColumn
            // 
            this.evictionDateDataGridViewTextBoxColumn.DataPropertyName = "EvictionDate";
            this.evictionDateDataGridViewTextBoxColumn.HeaderText = "Дата выселения";
            this.evictionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evictionDateDataGridViewTextBoxColumn.Name = "evictionDateDataGridViewTextBoxColumn";
            this.evictionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkinDateDataGridViewTextBoxColumn
            // 
            this.checkinDateDataGridViewTextBoxColumn.DataPropertyName = "Check_inDate";
            this.checkinDateDataGridViewTextBoxColumn.HeaderText = "Дата заселения";
            this.checkinDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkinDateDataGridViewTextBoxColumn.Name = "checkinDateDataGridViewTextBoxColumn";
            this.checkinDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodTypeIDDataGridViewTextBoxColumn
            // 
            this.foodTypeIDDataGridViewTextBoxColumn.DataPropertyName = "FoodTypeID";
            this.foodTypeIDDataGridViewTextBoxColumn.DataSource = this.foodTypesBindingSource;
            this.foodTypeIDDataGridViewTextBoxColumn.DisplayMember = "FoodTypeName";
            this.foodTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.foodTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип питания";
            this.foodTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodTypeIDDataGridViewTextBoxColumn.Name = "foodTypeIDDataGridViewTextBoxColumn";
            this.foodTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foodTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.foodTypeIDDataGridViewTextBoxColumn.ValueMember = "FoodTypeID";
            this.foodTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.DataSource = this.customersBindingSource;
            this.Column1.DisplayMember = "CustomerPatronymic";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Отчество клиента";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "CustomerID";
            this.Column1.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.DataSource = this.customersBindingSource;
            this.CustomerID.DisplayMember = "CustomerName";
            this.CustomerID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CustomerID.HeaderText = "Имя клиента";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CustomerID.ValueMember = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.DataSource = this.customersBindingSource;
            this.customerIDDataGridViewTextBoxColumn.DisplayMember = "CustomerSurname";
            this.customerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerIDDataGridViewTextBoxColumn.ValueMember = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.DataSource = this.employeesBindingSource;
            this.Login.DisplayMember = "Name";
            this.Login.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Login.HeaderText = "Имя сотрудника";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Login.ValueMember = "Login";
            this.Login.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.DataSource = this.employeesBindingSource;
            this.loginDataGridViewTextBoxColumn.DisplayMember = "Surname";
            this.loginDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.loginDataGridViewTextBoxColumn.HeaderText = "Фамилия сотрудника";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loginDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.loginDataGridViewTextBoxColumn.ValueMember = "Login";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "Номер запроса";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // RequestsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 537);
            this.Controls.Add(this.panel1);
            this.Name = "RequestsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RequestsPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource foodTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Login;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn foodTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evictionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalСostDataGridViewTextBoxColumn;
    }
}