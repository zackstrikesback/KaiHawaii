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
using ProjectCalendar.ViewModel;

namespace ProjectCalendar
{
    //TaskDisplay shows task info from calendar view.  Editing is not enabled.
    public partial class TaskDisplay : Window
    {
        public TaskDisplay()
        {
            InitializeComponent();
            tasks.IsReadOnly = true;
        }
    }
}
