using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar.Models
{
    public class WeekModel
    {
    }
    //Week class stores 7 Day objects and associates them with a day of the week.
    public class Week : INotifyPropertyChanged
    {
        private Day su;
        private Day mo;
        private Day tu;
        private Day we;
        private Day th;
        private Day fr;
        private Day sa;
        //If calendar headers for day of the week need to be modified, these day names
        //can be changed, or edit CalControl.
        public Day Su
        {
            get
            {
                return su;
            }
            set
            {
                su = value;
                RaisePropertyChanged("Su");
            }
        }
        public Day Mo
        {
            get
            {
                return mo;
            }
            set
            {
                mo = value;
                RaisePropertyChanged("Mo");
            }
        }
        public Day Tu
        {
            get
            {
                return tu;
            }
            set
            {
                tu = value;
                RaisePropertyChanged("Tu");
            }
        }
        public Day We
        {
            get
            {
                return we;
            }
            set
            {
                we = value;
                RaisePropertyChanged("We");
            }
        }
        public Day Th
        {
            get
            {
                return th;
            }
            set
            {
                th = value;
                RaisePropertyChanged("Th");
            }
        }
        public Day Fr
        {
            get
            {
                return fr;
            }
            set
            {
                fr = value;
                RaisePropertyChanged("Fr");
            }
        }
        public Day Sa
        {
            get
            {
                return sa;
            }
            set
            {
                sa = value;
                RaisePropertyChanged("Sa");
            }
        }
        //Takes a list of days and adds them in order from Sunday to Saturday.
        public void Add(List<Day> days)
        {
            if (days.Count > 0)
            {
                Su = days[0];
            }
            if (days.Count > 1)
            {
                Mo = days[1];
            }
            if (days.Count > 2)
            {
                Tu = days[2];
            }
            if (days.Count > 3)
            {
                We = days[3];
            }
            if (days.Count > 4)
            {
                Th = days[4];
            }
            if (days.Count > 5)
            {
                Fr = days[5];
            }
            if (days.Count > 6)
            {
                Sa = days[6];
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
