using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курорт.Pages
{
    public partial class PorterHomePage : Form
    {
        public PorterHomePage()
        {
            InitializeComponent();
        }
        //КНОПКИ
        private void OpenRequestsButton_Click(object sender, EventArgs e)//Кнопка "ЗАЯВКИ"
        {
            //Открывается страница с данными запросов
            RequestsPage requestsPage = new RequestsPage();
            requestsPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void OpenCustomersButton_Click(object sender, EventArgs e)
        {
            //Открывается страница с данными посетителей
            CustomersPage customersPage = new CustomersPage();
            customersPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void LogOutButton_Click(object sender, EventArgs e)//Кнопка "ВЫХОД ИЗ АККАУНТА"
        {
            //Возвращение на страницу регистрации 
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.Show();
            this.Hide();//Текущая страница скрывается
        }        
    }
}
