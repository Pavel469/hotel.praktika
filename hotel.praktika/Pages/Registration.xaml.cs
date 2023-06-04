using System;
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
using System.Windows.Shapes;

namespace hotel.praktika.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        HotelEntities context;
        public Registration(HotelEntities cont)
        {
            InitializeComponent();
         context= cont;
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Users users = new Users() { Login = emailBox.Text, Password = passwordBox.Text, service_number = service_numberBox.Text };
            context.Users.Add(users);
            context.SaveChanges();
            this.Close();

        }
    }
}
