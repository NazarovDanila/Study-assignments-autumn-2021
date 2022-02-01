using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratoryWork06_Northwind_NazarovDA.ModelEF;

namespace LaboratoryWork06_Northwind_NazarovDA
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
            orderBindingSource.DataSource = db.Orders.ToList();
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Order order = (Order)orderBindingSource.Current;
            order_DetailBindingSource.DataSource = order.Order_Details;
        }
    }
}
