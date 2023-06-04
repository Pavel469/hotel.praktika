﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace hotel.praktika.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        HotelEntities context;
        DispatcherTimer timer;
        public Authorization(HotelEntities cont)
        {
            InitializeComponent();
            context = cont;
            timer = new DispatcherTimer();
            timer.Interval= new TimeSpan(0,0,30);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           buttonEnter.IsEnabled= true;
            timer.Stop();
        }

        int countClick = 0;

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            countClick++;
            string log = loginBox.Text;
            string pass = passwordBox.Password;
                 Users users = context.Users.Find(log);
            /*Users u = context.Users.ToList().Find(x => x.age = 48);*/
            if (users!= null)
            {
                if (users.Password.Equals(pass))
                {
                    MessageBox.Show("Вы успешно авторизованы!");
                    countClick = 0;

                   
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный пароль!");
                    if (countClick >=3)
                    {
                        buttonEnter.IsEnabled = false;
                        timer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!");
                if (countClick >= 3)

                    buttonEnter.IsEnabled = false;
                timer.Start();
            }


        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            Registration regWindow = new Registration(context);
            regWindow.Show();
        }
    }
    }

