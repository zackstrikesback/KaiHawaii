using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar.Models
{
    public class ProjectTaskModel
    {
    }
    //ProjectTask class stores the task name, task notes, employees on the task, and the due date.
    public class ProjectTask : INotifyPropertyChanged, IEquatable<ProjectTask>
    {
        private string _TName;
        private string _Notes;
        private ObservableCollection<string> _Assigned;
        private DateTime _Due;


        public string TName
        {
            get
            {
                return _TName;
            }
            set
            {
                _TName = value;
                RaisePropertyChanged("TName");
            }
        }
        public string Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                _Notes = value;
                RaisePropertyChanged("Notes");
            }
        }
        public ObservableCollection<string> Assigned
        {
            get
            {
                return _Assigned;
            }
            set
            {
                _Assigned = value;
                RaisePropertyChanged("Assigned");
            }
        }
        public DateTime Due
        {
            get
            {
                return _Due;
            }
            set
            {
                _Due = value;
                RaisePropertyChanged("Tasks");
            }
        }

        public ProjectTask(string t, string n, ObservableCollection<string> a, DateTime d)
        {
            TName = t;
            Notes = n;
            Assigned = a;
            Due = d;
        }
        //ProjectTasks are considered the same only if their name matches.
        public bool Equals(ProjectTask other)
        {
            return this.TName == other.TName;
        }
        //Text file will show the format:
        //**Task1Name**Task1Notes**Employee1,Employee2**DateDue
        public override string ToString()
        {
            return string.Format("**{0}**{1}**{2}**{3}{4}", this.TName, this.Notes, string.Join(",", this.Assigned), this.Due, Environment.NewLine);
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
