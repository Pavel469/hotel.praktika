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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotel.praktika.Pages
{
    /// <summary>
    /// Логика взаимодействия для RememberPassPage.xaml
    /// </summary>
    public partial class RememberPassPage : Page
    {
        Users _users;
        public RememberPassPage(Users users)
        {
            InitializeComponent();
            loginBox.Text = users.Login;
            _users = users;

        }

        private void ShowPassword(object sender, RoutedEventArgs e)
        {
            if (_users.Login == loginBox.Text && _users.service_number == servicenumber.Text)
                MessageBox.Show($" Ваш пароль{_users.Password}", "Пароль", MessageBoxButton.OK, MessageBoxImage.Information);






        }
    }
}
