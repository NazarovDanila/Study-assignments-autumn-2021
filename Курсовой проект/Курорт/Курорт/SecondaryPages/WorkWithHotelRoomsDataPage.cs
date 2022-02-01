﻿using System;
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
    public partial class WorkWithHotelRoomsDataPage : Form
    {
        public Model1 db { get; set; }
        public HotelRooms rooms { get; set; }
        public WorkWithHotelRoomsDataPage()
        {
            InitializeComponent();
        }
        private void WorkWithHotelRoomsDataPage_Load(object sender, EventArgs e)
        {
            if (rooms == null)//Если emp задано значение null, то нужно создать новую запись
            {
                hotelRoomsBindingSource.AddNew();// добавляем новую пустую запись в employeesBindingSource 
                PageNameLabel.Text = "Добавление данных";// задаем название формы для вывода на экран
            }
            else //если ter присвоен объект, то нужно его корректировать
            {
                hotelRoomsBindingSource.Add(rooms);// добавляем переданный объект в employeesBindingSource                    
                PageNameLabel.Text = "Изменение данных";// задаем название формы
            }
        }
        //КНОПКИ
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (rooms == null)// если создан новый объект, то 
            {
                rooms = (HotelRooms)hotelRoomsBindingSource.Current;//получаем его из локальной памяти                
                db.HotelRooms.Add(rooms);// добавляем созданный и заполненный объект в коллекцию модели
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
