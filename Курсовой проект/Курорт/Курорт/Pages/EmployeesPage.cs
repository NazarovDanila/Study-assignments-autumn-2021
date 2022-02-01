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
    public partial class EmployeesPage : Form
    {
        Model1 db = new Model1();
        public EmployeesPage()
        {
            InitializeComponent();
        }
        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            //Передача данных из таблиц на страницу
            postsBindingSource.DataSource = db.Posts.ToList();
            employeesBindingSource.DataSource = db.Employees.ToList();
        }
        //КНОПКИ
        private void AddDataButton_Click(object sender, EventArgs e)//Кнопка "ДОБАВИТЬ"
        {
            WorkWithEmployeeDataPage page = new WorkWithEmployeeDataPage();//Создаем объект формы
            page.db = db;
            page.emp = null;//Передаем в WorkWithDataPage значение null для свойства usr
                            //т.е. сообщаем, что нужно создать новый объект
            DialogResult dr = page.ShowDialog();// показываем форму в диалоговом режиме            
            if (dr == DialogResult.OK)//Если пользователь DialogResut == OK
            {
                //Обновляем данные для ЭУ DataGridView
                employeesBindingSource.DataSource = null;
                employeesBindingSource.DataSource = db.Employees.ToList();
            }
        }
        private void ChangeDataButton_Click(object sender, EventArgs e)//Кнопка "ИЗМЕНИТЬ"
        {
            Employees emp = (Employees)employeesBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            WorkWithEmployeeDataPage page = new WorkWithEmployeeDataPage();//Создаем форму для работы с данными            
            page.db = db;
            page.emp = emp;//Передаем в форму объект 
            DialogResult dr = page.ShowDialog();//Показываем форму в диалоговом режиме (возвращает DialogResult)
            if (dr == DialogResult.OK)//Если пользователь нажал кнопку «Сохранить» (у нее DialogResut = OK)
            {
                //Обновляем данные для ЭУ DataGridView
                employeesBindingSource.DataSource = null;
                employeesBindingSource.DataSource = db.Employees.ToList();
            }
        }
        private void DelDataButton_Click(object sender, EventArgs e)//Кнопка "УДАЛИТЬ"
        {
            Employees emp = (Employees)employeesBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            // показываем сообщение с заданием всех параметров
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись о сотруднике - " + emp.Surname.ToString()
                + "?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Показываем диалоговое окно с кнопками Yes и No
            if (dr == DialogResult.Yes)//Если пользователь нажал кнопку «Yes»
            {
                db.Employees.Remove(emp);//Удаляем выбранный объект из коллекции
                //Сохраняем сделанные изменения в БД
                try//Обрабатываем исключения
                {
                    db.SaveChanges();//Сохраняем сделанные изменения в БД                    
                    employeesBindingSource.DataSource = db.Employees.ToList();//Обновляем содержание userBindingSource
                }
                catch (Exception ex)//Если ошибка, то попадаем сюда
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);//Выводим сообщение SQL Server об ошибке
                }
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)//Кнопка "Х" (закрыть)
        {
            //Пользователь возвращается на предыдущую страницу
            AdministratorHomePage administratorHomePage = new AdministratorHomePage();
            administratorHomePage.FormClosed += formClosed;
            this.Hide();//Текущая страница скрывается
            administratorHomePage.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
