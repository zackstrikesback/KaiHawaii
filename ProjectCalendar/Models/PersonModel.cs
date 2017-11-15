using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ProjectCalendar.Models
{
    public class PersonModel
    {
    }
    //Person class store employee information of first name, last name,
    //and email[firstname lastname (email@kaihawaii.com)] as strings.
    public class Person : INotifyPropertyChanged
    {
        private string _fName;
        private string _lName;
        private string _eMail;

        public string FirstName
        {
            get
            {
                return _fName;
            }
            set
            {
                _fName = value;
                RaisePropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return _lName;
            }
            set
            {
                _lName = value;
                RaisePropertyChanged("LastName");
            }
        }
        public string Email
        {
            get
            {
                return _eMail;
            }
            set
            {
                _eMail = value;
                RaisePropertyChanged("Email");
            }
        }

        public Person(string fname, string lname, string email)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
        }
        public override string ToString()
        {
            return string.Format("{0}**{1}**{2}", this.FirstName, this.LastName, this.Email);
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
