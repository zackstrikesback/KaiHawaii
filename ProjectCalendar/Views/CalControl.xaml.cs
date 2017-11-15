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
using ProjectCalendar.ViewModel;
using ProjectCalendar.Models;

namespace ProjectCalendar
{
    //CalControl loads current project tasks and displays their due dates in calendar form.
    public partial class CalControl : UserControl
    {
        public static DateTime current;
        public static Person select;

        public CalControl()
        {
            current = DateTime.Now;
            DayViewModel days = new DayViewModel();
            WeekViewModel weeks = new WeekViewModel();
            weeks.Load(days.Days);
            PersonViewModel per = new PersonViewModel();
            per.Load();
            InitializeComponent();
            controlGrid.DataContext = weeks;
            User.DataContext = per;
            lblDate.Text = getMonth();
            controlGrid.IsReadOnly = true;
            controlGrid.RowHeight = 75;
        }
        //Changes calendar to next month and loads it.
        private void btnDateRight_Click(object sender, RoutedEventArgs e)
        {
            current = current.AddMonths(1);
            lblDate.Text = getMonth();
            DayViewModel days = new DayViewModel();
            WeekViewModel weeks = new WeekViewModel();
            weeks.Load(days.Days);
            controlGrid.DataContext = weeks;
        }
        //Changes calendar to previous month and loads it.
        private void btnDateLeft_Click(object sender, RoutedEventArgs e)
        {
            current = current.AddMonths(-1);
            lblDate.Text = getMonth();
            DayViewModel days = new DayViewModel();
            WeekViewModel weeks = new WeekViewModel();
            weeks.Load(days.Days);
            controlGrid.DataContext = weeks;
        }
        //Gets current month and year to display at top of calendar.
        private string getMonth()
        {
            return CalControl.current.ToString("MMMM yyyy");
        }
        //Selecting a day displays a popup TaskDisplay window that lists information about the tasks due that day.
        private void controlGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (controlGrid.CurrentCell.Column != null)
            {
                int d = controlGrid.CurrentCell.Column.DisplayIndex;
                Week selected = (Week)controlGrid.CurrentCell.Item;
                Day selectedDay = new Day();
                switch (d)
                {
                    case 0:
                        selectedDay = selected.Su;
                        break;
                    case 1:
                        selectedDay = selected.Mo;
                        break;
                    case 2:
                        selectedDay = selected.Tu;
                        break;
                    case 3:
                        selectedDay = selected.We;
                        break;
                    case 4:
                        selectedDay = selected.Th;
                        break;
                    case 5:
                        selectedDay = selected.Fr;
                        break;
                    case 6:
                        selectedDay = selected.Sa;
                        break;
                }
                string date = selectedDay.Date.ToString("d");
                TaskDisplay winT = new TaskDisplay();
                winT.DataContext = selectedDay;
                winT.Title = "Tasks due: " + date;
                winT.ShowDialog();
            } 
        }
        //Selection of user filters calendar view to display only tasks that the user is assigned.
        private void User_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            select = (Person)User.SelectedItem;
            if (select != null)
            {
                calUser.Text = select.FirstName + " " + select.LastName + "'s Calendar";
            }
            else
            {
                calUser.Text = "Calendar";
            }
            DayViewModel days = new DayViewModel();
            WeekViewModel weeks = new WeekViewModel();
            weeks.Load(days.Days);
            controlGrid.DataContext = weeks;
            e.Handled = true;
        }
        //All button clears user selection and displays all tasks for the month.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            select = null;
            DayViewModel days = new DayViewModel();
            WeekViewModel weeks = new WeekViewModel();
            PersonViewModel per = new PersonViewModel();
            per.Load();
            weeks.Load(days.Days);
            controlGrid.DataContext = weeks;
            User.DataContext = per;
            calUser.Text = "Calendar";
        }
    }
}
