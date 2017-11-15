using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCalendar.Models;
using System.Collections.ObjectModel;

namespace ProjectCalendar.ViewModel
{
    public class DayViewModel
    {
        public ObservableCollection<Day> Days
        {
            get;
            set;
        }
        //Loads current calendar view month.
        public DayViewModel()
        {
            Days = new ObservableCollection<Day>();
            LoadMonth(CalControl.current.Year, CalControl.current.Month);
        }
        //Loads a month full of days and matches tasks with their due date and employee assigned.
        public void LoadMonth(int year, int month)
        {
            List<DateTime> currMonth = GetDates(year, month);
            foreach (var d in currMonth)
            {
                ObservableCollection<ProjectTask> ts = new ObservableCollection<ProjectTask>();
                foreach(Project x in MainWindow.p.Proj.Projects)
                {
                    foreach(ProjectTask t in x.Tasks)
                    {
                        if (CalControl.select != null)
                        {
                            if (t.Due == d && t.Assigned.Contains(CalControl.select.Email))
                            {
                                ts.Add(t);
                            }
                        }
                        else
                        {
                            if (t.Due == d)
                            {
                                ts.Add(t);
                            }
                        }
                    }
                }
                Days.Add(new Day(d, ts));
            }
        }
        //Gets a list of dates for the month
        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day)) // Map each day to a date
                             .ToList(); // Load dates into a list
        }
    }
}
