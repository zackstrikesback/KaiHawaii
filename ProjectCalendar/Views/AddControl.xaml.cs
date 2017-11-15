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
using System.IO;
using System.Data;
using System.Reflection;
using System.Web;
using ProjectCalendar.Models;
using ProjectCalendar.ViewModel;
using ProjectCalendar;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar
{
    //AddControl is used for adding NEW projects and tasks to the current projects.
    public partial class AddControl : UserControl
    {
        public static bool DateVisibility { get; set; }  //Visible for adding Tasks and Invisible for adding Projects.
        public static ObservableCollection<string> members;  //Employees assigned to project.

        private string selected;  //Employee to add to project.
        private string delete;  //Employee to remove from project.
        //User input.
        private string name;
        private string notes;

        private DateTime due;  //User selected due date.

        public static Window win;

        public AddControl()
        {
            InitializeComponent();
            DataContext = MainWindow.p;
            members = new ObservableCollection<string>();
            members.Add(MainWindow.user.Email);  //Automatically adds user to assigned list
            uxEmpList.ItemsSource = members;
            if (DateVisibility)
            {
                uxDate.Visibility = Visibility.Visible;
                uxDue.Visibility = Visibility.Visible;
                uxEmpCombo.ItemsSource = MainWindow.p.SelectedProject.Assigned;  //If adding a task, only the employees already added to the project are available.
                uxEmpCombo.DisplayMemberPath = "";
            }
            else
            {
                uxDate.Visibility = Visibility.Collapsed;
                uxDue.Visibility = Visibility.Collapsed;
            }
        }
   
        private void uxEmpCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateVisibility)
            {
                selected = (string)uxEmpCombo.SelectedItem;
            }
            else
            {
                Person select = (Person)uxEmpCombo.SelectedItem;
                selected = select.Email;
            }
            e.Handled = true;
        }
        //Adds new employee to assigned list.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!members.Contains(selected))
            {
                members.Add(selected);
                uxEmpList.Items.Refresh();
            }
        }

        private void uxEmpList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(uxEmpList.SelectedItem != null)
            {
                delete = uxEmpList.SelectedItem.ToString();
            }
            e.Handled = true;
        }
        //Removes selected employee from assigned list.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            members.Remove(delete);
            delete = "";
            uxEmpList.Items.Refresh();
        }

        private void uxDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (uxDate.SelectedDate.HasValue)
            {
                due = uxDate.SelectedDate.Value;
            }
            e.Handled = true;
        }
        //Saves and adds new project/task to current list.  All fields are required to be filled in.
        //Closes Window that AddControl is loaded in on successful save.
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uxName.Text) || string.IsNullOrWhiteSpace(uxNotes.Text) || !members.Any())
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                if (!DateVisibility)
                {
                    name = uxName.Text;
                    notes = uxNotes.Text;
                    ObservableCollection<ProjectTask> tasks = new ObservableCollection<ProjectTask>();
                    Project p = new Project(name, notes, members, tasks);
                    MainWindow.p.Proj.AddProject(p);
                    MainWindow.Save();
                    win.Close();
                }
                else
                {
                    if (uxDate.SelectedDate == null)
                    {
                        MessageBox.Show("Please fill in all fields");
                    }
                    else
                    {
                        name = uxName.Text;
                        notes = uxNotes.Text;
                        ProjectTask t = new ProjectTask(name, notes, members, due);
                        MainWindow.p.Proj.AddTask(MainWindow.p.SelectedProject, t);
                        MainWindow.Save();
                        win.Close();
                    }
                }
            }
        }
        //Used to capture window AddControl is loaded in.
        private void AddCont_Loaded(object sender, RoutedEventArgs e)
        {
            win = Window.GetWindow(this);     
        }
    }
}
