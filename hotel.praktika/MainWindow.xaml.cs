using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace hotel.praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*  public void DownloadPictures()
          {
              using (HotelEntities context = new HotelEntities())
              {
                  foreach (var item in context.Archive.ToList())
                  {
                      item.Photo = File.ReadAllBytes($"C:\Archive{item.Id}.png");
                  }
                  context.SaveChanges();
              }
          }
      }*/
    }
}
