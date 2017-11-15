using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar.Models
{
    public class DayModel
    {
    }
    //Day class stores the date and the tasks that occur on that day. Also stores the
    //day of the month as an int for easy access.
    public class Day : INotifyPropertyChanged
    {
        private DateTime _Date;
        private ObservableCollection<ProjectTask> _dTasks;
        private int _DayNo;

        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
                _DayNo = _Date.Day;
                RaisePropertyChanged("Date");
            }
        }
        public ObservableCollection<ProjectTask> DTasks
        {
            get
            {
                return _dTasks;
            }
            set
            {
                _dTasks = value;
                RaisePropertyChanged("Tasks");
            }
        }
        public int DayNo
        {
            get
            {
                return _DayNo;
            }
            set
            {
                _DayNo = value;
                RaisePropertyChanged("DayNo");
            }
        }

        public Day()
        {
        }

        public Day(DateTime d, ObservableCollection<ProjectTask> t)
        {
            Date = d;
            DTasks = t;
        }
        //overrides to string method to display the day of the month followed by the
        //tasks names displayed line by line
        public override string ToString()
        {
            if (DTasks == null)
            {
                if (DayNo != 0)
                {
                    return DayNo.ToString();
                }
                else
                {
                    return "";
                }
            }
            else
            {
                List<string> t = new List<string>();
                foreach (ProjectTask d in DTasks)
                {
                    t.Add(d.TName);
                }
                return string.Format("{0}{1}{2}", DayNo, Environment.NewLine, string.Join("\n", t));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
