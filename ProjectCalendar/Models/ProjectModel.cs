using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar.Models
{
    public class ProjectModel
    {
    }
    //Project class stores the project name, project notes, employees on the project and the project tasks.
    public class Project : INotifyPropertyChanged, IEquatable<Project>
    {
        private string _PName;
        private string _Notes;
        private ObservableCollection<string> _Assigned;
        private ObservableCollection<ProjectTask> _Tasks;


        public string PName
        {
            get
            {
                return _PName;
            }
            set
            {
                _PName = value;
                RaisePropertyChanged("PName");
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
        public ObservableCollection<ProjectTask> Tasks
        {
            get
            {
                return _Tasks;
            }
            set
            {
                _Tasks = value;
                RaisePropertyChanged("Tasks");
            }
        }

        public Project(string p, string n, ObservableCollection<string> a, ObservableCollection<ProjectTask> t)
        {
            PName = p;
            Notes = n;
            Assigned = a;
            Tasks = t;
        }
        //Projects are considered the same only if their name matches.
        public bool Equals(Project other)
        {
            return this.PName == other.PName;
        }
        //Removes employee from project.
        public static void Remove(Project p, string name)
        {
            p.Assigned.Remove(name);
        }
        //Adds employee to project unless they're already on the project.
        public void Add(Project p, string name)
        {
            if (!p.Assigned.Contains(name))
            {
                p.Assigned.Add(name);
            }
        }
        //Text file will show this format for projects:
        //ProjName**ProjNotes**Employee1,Employee2,Employee3
        //**Task1Name**Task1Notes**Employee1,Employee2**DateDue
        //**Task2Name**Task2Notes**Employee2,Employee3**DateDue
        //+++
        public override string ToString()
        {
            if (!this.Tasks.Any())
            {
                return string.Format("{0}**{1}**{2}{3}+++", this.PName, this.Notes, string.Join(",", this.Assigned), Environment.NewLine);
            }
            else
            {
                return string.Format("{0}**{1}**{2}{3}{4}+++", this.PName, this.Notes, string.Join(",", this.Assigned), Environment.NewLine, string.Join("", this.Tasks));
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
