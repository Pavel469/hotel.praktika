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

namespace hotel.praktika.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientyPage.xaml
    /// </summary>
    public partial class ClientyPage : Page
    {
        HotelEntities context;
        public ClientyPage(HotelEntities _cont)
        {
           
            InitializeComponent();
      /*      context = _cont;
            countCli.Text = $"{context.Client.Count()}ФИО";
            sumCli.Text = $"Количество свободных комнат {context.Client.Sum((x.))}";*/


        }

        
    }
}
