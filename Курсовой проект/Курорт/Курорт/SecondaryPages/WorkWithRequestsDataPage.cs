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

namespace Курорт.Pages
{
    public partial class WorkWithRequestsDataPage : Form
    {
        public Model1 db { get; set; }
        public Requests req { get; set; }
        public WorkWithRequestsDataPage()
        {
            InitializeComponent();
        }
        private void WorkWithRequestsDataPage_Load(object sender, EventArgs e)
        {
            if (req == null)//Если emp задано значение null, то нужно создать новую запись
            {
                requestsBindingSource.AddNew();// добавляем новую пустую запись в employeesBindingSource 
                PageNameLabel.Text = "Добавление данных";// задаем название формы для вывода на экран
            }
            else //если ter присвоен объект, то нужно его корректировать
            {
                requestsBindingSource.Add(req);// добавляем переданный объект в employeesBindingSource                    
                PageNameLabel.Text = "Изменение данных";// задаем название формы
            }
        }
        //КНОПКИ
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (req == null)// если создан новый объект, то 
            {
                req = (Requests)requestsBindingSource.Current;//получаем его из локальной памяти                
                db.Requests.Add(req);// добавляем созданный и заполненный объект в коллекцию модели
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
