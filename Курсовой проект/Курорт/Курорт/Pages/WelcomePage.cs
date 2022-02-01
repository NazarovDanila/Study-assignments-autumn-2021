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

namespace Курорт
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)//Кнопка "ВХОД"
        {
            //Переход на страницу регистрации
            RegistrationPage registrationPage = new RegistrationPage();         
            registrationPage.Show();            
            this.Hide();//Текущая страница скрывается
        }
        private void CloseButton_Click(object sender, EventArgs e)//Кнопка "ВЫХОД"
        {
            Application.Exit();//Закрытие приложения
        }
    }
}
