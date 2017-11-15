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
using ProjectCalendar.Models;
using ProjectCalendar.ViewModel;

namespace ProjectCalendar.Views
{
    //ProjectViewControl displays current projects and their tasks and allows editing.
    public partial class ProjectViewControl : UserControl
    {
        public ProjectViewControl()
        {
            InitializeComponent();
            Disable();;
        }
        //True if a project is selected by user.
        private bool Selected()
        {
            if (uxList.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void Disable()
        {
            btnAdd.IsEnabled = false;
            btnRemove.IsEnabled = false;
            btnSave.IsEnabled = false;
            btnTAdd.IsEnabled = false;
            btnTRemove.IsEnabled = false;
            btnTSave.IsEnabled = false;
            uxTDate.IsEnabled = false;
            uxName.IsReadOnly = true;
            uxNotes.IsReadOnly = true;
            uxTName.IsReadOnly = true;
            uxTNotes.IsReadOnly = true;
            btnTask.IsEnabled = false;
        }
        private void Enable()
        {
            btnAdd.IsEnabled = true;
            btnRemove.IsEnabled = true;
            btnSave.IsEnabled = true;
            btnTAdd.IsEnabled = true;
            btnTRemove.IsEnabled = true;
            btnTSave.IsEnabled = true;
            uxTDate.IsEnabled = true;
            uxName.IsReadOnly = false;
            uxNotes.IsReadOnly = false;
            uxTName.IsReadOnly = false;
            uxTNotes.IsReadOnly = false;
            btnTask.IsEnabled = true;
        }
        //Enables buttons and editing if a project is selected.
        private void uxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!Selected())
            {
                Disable();
            }
            else
            {
                Enable();
            }
        }
        //Allows user to add a new task to the project by displaying a popup NewTaskWindow
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewTaskWindow winAddT = new NewTaskWindow();
            winAddT.ShowDialog();
        }
    }
}
