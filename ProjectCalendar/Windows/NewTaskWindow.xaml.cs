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

namespace ProjectCalendar
{
    //NewProjWindow displays AddControl for adding a new Task
    public partial class NewTaskWindow : Window
    {
        public NewTaskWindow()
        {
            AddControl.DateVisibility = true;
            InitializeComponent();
        }
    }
}
