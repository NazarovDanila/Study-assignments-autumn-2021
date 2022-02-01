using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork05_Northwind_NazarovDA
{
    public partial class DisplayTablePage : Form
    {
        Model1 db = new Model1();//Создаём объект контекста класса Model1
        public DisplayTablePage()
        {
            InitializeComponent();
        }
        private void DisplayTablePage_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = db.Employees.ToList();//Передача данных из таблицы Employees
            orderBindingSource.DataSource = db.Orders.ToList();//Передача данных из таблицы Orders
        }
        private void CloseApplicationButton_Click(object sender, EventArgs e)//Кнопка "Х" (закрыть)
        {
            this.Close();//Закрытие приложения
        }
    }
}
