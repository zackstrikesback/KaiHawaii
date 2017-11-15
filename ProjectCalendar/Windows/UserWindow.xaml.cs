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
using ProjectCalendar.Models;
using ProjectCalendar.ViewModel;

namespace ProjectCalendar
{
    //UserWindow allows user to change application user.
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            DataContext = new MasterViewModel();
            InitializeComponent();
        }

        private void uxUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.user = (Person)uxUserList.SelectedItem;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
