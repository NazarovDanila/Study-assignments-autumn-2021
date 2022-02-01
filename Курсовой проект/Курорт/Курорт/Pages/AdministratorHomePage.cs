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

namespace Курорт.Pages
{
    
    public partial class AdministratorHomePage : Form
    {
        Model1 db = new Model1();
        public AdministratorHomePage()
        {
            InitializeComponent();
        }
        //КНОПКИ
        private void OpenEmployeesButton_Click(object sender, EventArgs e)//Кнопка "СОТРУДНИКИ"
        {
            //Открывается страница с данными сотрудников
            EmployeesPage employeesPage = new EmployeesPage();
            employeesPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void OpenCustomersButton_Click(object sender, EventArgs e)
        {
            //Открывается страница с данными посетителей
            CustomersPage customersPage = new CustomersPage();
            customersPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void OpenHotelRoomsButton_Click(object sender, EventArgs e)//Кнопка "НОМЕРА"
        {
            //Открывается страница с данными номеров отеля
            HotelRoomsPage hotelRoomsPage = new HotelRoomsPage();
            hotelRoomsPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void OpenFoodTypeButton_Click(object sender, EventArgs e)//Кнопка "ТИПЫ ПИТАНИЯ"
        {
            //Открывается страница с данными типов питания
            FoodTypePage foodTypePage = new FoodTypePage();
            foodTypePage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void OpenRequestsButton_Click(object sender, EventArgs e)//Кнопка "ЗАЯВКИ"
        {
            //Открывается страница с данными запросов
            RequestsPage requestsPage = new RequestsPage();
            requestsPage.Show();
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
