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
    public partial class RegistrationPage : Form
    {
        Model1 db = new Model1();
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Проверка на существование пользователя в базе данных по Логину и паролю
            if (loginField.Text == "" || passField.Text == "")//Проверяем, что все требуемые данные введены
            {
                MessageBox.Show(" Для входа в систему нужно ввести логин и пароль! ");//Выводится сообщение о том, что нужно заполнить все поля
                return;
            }
            //Проверяем, существует ли пользователь с введённым логином и паролем
            string log = loginField.Text;
            string pas = passField.Text;
            var listOfUsers = db.Employees.ToList();
            bool isFind = false;
            foreach (var user in listOfUsers)
            {
                if (user.Login == log && user.Password == pas && user.PostID == "01")//Если пользователь - администратор, то
                {
                    isFind = true;
                    //Открытие главной формы Администратора
                    AdministratorHomePage administratorHomePage = new AdministratorHomePage();
                    administratorHomePage.Show();
                    this.Hide();//Формы для авторизации пользователя скрывается
                }
                else if (user.Login == log && user.Password == pas && user.PostID == "02")//Если пользователь - портье, то
                {
                    isFind = true;
                    //Открытие главной формы Портье
                    PorterHomePage porterHomePage = new PorterHomePage();
                    porterHomePage.Show();
                    this.Hide();//Формы для авторизации пользователя скрывается
                }
                //Поля для ввода логина и пароля очищаются
                loginField.Clear();
                passField.Clear();
            }
            if (!isFind)//Если пользователь с введённым логином и паролем не существует, то
            {
                MessageBox.Show("Такого пользователя не существует!");//Вывод сообщения об ошибке
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)//Кнопка "ВЫХОД"
        {
            Application.Exit();//Закрытие приложения
        }
    }
}
