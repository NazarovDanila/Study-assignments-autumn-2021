
namespace LaboratoryWork05_Northwind_NazarovDA
{
    partial class DisplayTablePage
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelAboutMe = new System.Windows.Forms.Label();
            this.PageName = new System.Windows.Forms.Label();
            this.CloseApplicationButton = new System.Windows.Forms.Label();
            this.Task = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-15, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 337);
            this.panel1.TabIndex = 0;
            // 
            // LabelAboutMe
            // 
            this.LabelAboutMe.AutoSize = true;
            this.LabelAboutMe.Location = new System.Drawing.Point(12, 9);
            this.LabelAboutMe.Name = "LabelAboutMe";
            this.LabelAboutMe.Size = new System.Drawing.Size(158, 17);
            this.LabelAboutMe.TabIndex = 1;
            this.LabelAboutMe.Text = "Назаров Данила 31ИС";
            // 
            // PageName
            // 
            this.PageName.AutoSize = true;
            this.PageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageName.Location = new System.Drawing.Point(139, 37);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(527, 36);
            this.PageName.TabIndex = 2;
            this.PageName.Text = "Работа с базой данных \"Northwind\".";
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.AutoSize = true;
            this.CloseApplicationButton.BackColor = System.Drawing.Color.Gray;
            this.CloseApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApplicationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseApplicationButton.Location = new System.Drawing.Point(761, 9);
            this.CloseApplicationButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(26, 25);
            this.CloseApplicationButton.TabIndex = 3;
            this.CloseApplicationButton.Text = "X";
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButton_Click);
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Location = new System.Drawing.Point(290, 82);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(214, 34);
            this.Task.TabIndex = 4;
            this.Task.Text = "ЛР05 (Практическая работа 6)\r\n                Вариант 21";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.employeeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeLastName";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIDDataGridViewTextBoxColumn.ValueMember = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(LaboratoryWork05_Northwind_NazarovDA.Employee);
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            this.requiredDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shippedDateDataGridViewTextBoxColumn
            // 
            this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
            this.shippedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipViaDataGridViewTextBoxColumn
            // 
            this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
            this.shipViaDataGridViewTextBoxColumn.Width = 125;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            this.freightDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipNameDataGridViewTextBoxColumn
            // 
            this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
            this.shipNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipAddressDataGridViewTextBoxColumn
            // 
            this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
            this.shipAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            this.shipCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipRegionDataGridViewTextBoxColumn
            // 
            this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
            this.shipRegionDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipPostalCodeDataGridViewTextBoxColumn
            // 
            this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
            this.shipPostalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipCountryDataGridViewTextBoxColumn
            // 
            this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
            this.shipCountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(LaboratoryWork05_Northwind_NazarovDA.Order);
            // 
            // DisplayTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.CloseApplicationButton);
            this.Controls.Add(this.PageName);
            this.Controls.Add(this.LabelAboutMe);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayTablePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DisplayTablePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelAboutMe;
        private System.Windows.Forms.Label PageName;
        private System.Windows.Forms.Label CloseApplicationButton;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label Task;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
    }
}

