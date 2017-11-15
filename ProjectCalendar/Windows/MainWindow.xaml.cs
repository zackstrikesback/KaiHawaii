using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using ProjectCalendar.Models;
using ProjectCalendar.ViewModel;
using ProjectCalendar.Views;


namespace ProjectCalendar
{
    //MainWindow is the primary user interface.
    public partial class MainWindow : Window
    {
        public static MasterViewModel p;
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  //Currently saves to user's myDocuments folder
        public static string file = path + "\\myProjects.txt";  //C:\Users\username\Documents\myProjects.txt
        public static Person user;
        //Loads MasterViewModel containing the current projects from myProjects.txt.
        //Loads Application user or forces user to set one if none exists.
        public MainWindow()
        {
            p = new MasterViewModel();
            InitializeComponent();
            if (user == null)
            {
                UserWindow winU = new UserWindow();
                winU.ShowDialog();
            }
            Title = user.LastName + ", " + user.FirstName + " Project Calendar";
        }
        //Creates popup NewProjWindow with AddControl to add new Project.
        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            NewProjWindow winAddP = new NewProjWindow();
            winAddP.ShowDialog();
        }
        //Gives ProjectViewControl the current data from text file on load.
        private void ProjViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            ProjViewControl.DataContext = p;
        }
        //Saves current project list.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }
        //Writes current project list to myProjects.txt file.
        public static void Save()
        {
            using (TextWriter tw = new StreamWriter(file))
            {
                tw.WriteLine(user.ToString());
                foreach (var Project in p.Proj.Projects)
                {
                    tw.WriteLine(Project.ToString());
                }
            }
        }
        //Saves current project list.
        private void uxFileSave_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }
        //Quits current application session.  Asks to save before closing.
        private void uxFileQuit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Save before closing?", "Changes will be lost.", MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                Save();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        //Allows user to change Application user.  Currently all it does is change the name
        //at top of text file and application and which user is automatically assigned when
        //creating a new project/task.
        private void uxContextUserChange_Click(object sender, RoutedEventArgs e)
        {
            UserWindow winU = new UserWindow();
            winU.ShowDialog();
            Title = user.LastName + ", " + user.FirstName + " Project Calendar";
        }
        //Creates a new popup CalendarWindow to show calendar view.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CalendarWindow winCal = new CalendarWindow();
            winCal.ShowDialog();
        }
    }
}
