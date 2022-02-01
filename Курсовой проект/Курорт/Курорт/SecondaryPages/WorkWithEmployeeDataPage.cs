using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курорт.ModelEF;
using Курорт.Pages;
using Курорт.SecondaryPages;

namespace Курорт.SecondaryPages
{
    public partial class WorkWithEmployeeDataPage : Form
    {
        public Model1 db { get; set; }
        public Employees emp { get; set; }
        public WorkWithEmployeeDataPage()
        {
            InitializeComponent();
        }
        private void WorkWithEmployeeDataPage_Load(object sender, EventArgs e)
        {
            if (emp == null)//Если emp задано значение null, то нужно создать новую запись
            {
                employeesBindingSource1.AddNew();// добавляем новую пустую запись в employeesBindingSource 
                PageNameLabel.Text = "Добавление данных";// задаем название формы для вывода на экран
            }
            else //если ter присвоен объект, то нужно его корректировать
            {
                employeesBindingSource1.Add(emp);// добавляем переданный объект в employeesBindingSource                    
                PageNameLabel.Text = "Изменение данных";// задаем название формы
            }
        }
        //КНОПКИ
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {            
            if (emp == null)// если создан новый объект, то 
            {
                emp = (Employees)employeesBindingSource1.Current;//получаем его из локальной памяти                
                db.Employees.Add(emp);// добавляем созданный и заполненный объект в коллекцию модели
            }
            try
            {
                db.SaveChanges();// пытаемся сохранить сделанные изменения в БД
                DialogResult = DialogResult.OK;// если задать значение свойству DialogResult, то форма закроется
            }
            catch (Exception ex)// если возникла ошибка, то показываем сообщение
            {
                MessageBox.Show("Ошибка " + ex.Message);// если DialogResult значение не задано, форма не закрывается
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Текущая страница скрывается
        }
    }
}
