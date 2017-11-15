using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCalendar.Models;
using System.Collections.ObjectModel;

namespace ProjectCalendar.ViewModel
{
    public class WeekViewModel
    {
        public ObservableCollection<Week> Weeks
        {
            get;
            set;
        }
        //Loads days in month into separate weeks based on the first day
        //of the current month
        public void Load(ObservableCollection<Day> D)
        {
            List<Day> week1 = new List<Day>();
            List<Day> week2 = new List<Day>();
            List<Day> week3 = new List<Day>();
            List<Day> week4 = new List<Day>();
            List<Day> week5 = new List<Day>();
            List<Day> week6 = new List<Day>();
            Week w1 = new Week();
            Week w2 = new Week();
            Week w3 = new Week();
            Week w4 = new Week();
            Week w5 = new Week();
            Week w6 = new Week();
            Weeks = new ObservableCollection<Week>();
            DayOfWeek firstDay = D[0].Date.DayOfWeek;
            int n = D.Count;
            switch (firstDay)
            {
                case DayOfWeek.Sunday:
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 7)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 14)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 21)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 28)
                        {
                            week4.Add(D[i]);
                        }
                        else
                        {
                            week5.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    break;
                case DayOfWeek.Monday:
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 6)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 13)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 20)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 27)
                        {
                            week4.Add(D[i]);
                        }
                        else
                        {
                            week5.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    break;
                case DayOfWeek.Tuesday:
                    week1.Add(new Day());
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 5)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 12)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 19)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 26)
                        {
                            week4.Add(D[i]);
                        }
                        else
                        {
                            week5.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    break;
                case DayOfWeek.Wednesday:
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 4)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 11)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 18)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 25)
                        {
                            week4.Add(D[i]);
                        }
                        else
                        {
                            week5.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    break;
                case DayOfWeek.Thursday:
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 3)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 10)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 17)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 24)
                        {
                            week4.Add(D[i]);
                        }
                        else
                        {
                            week5.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    break;
                case DayOfWeek.Friday:
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 2)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 9)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 16)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 23)
                        {
                            week4.Add(D[i]);
                        }
                        else if (i < 30)
                        {
                            week5.Add(D[i]);
                        }
                        else
                        {
                            week6.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    w6.Add(week6);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    Weeks.Add(w6);
                    break;
                case DayOfWeek.Saturday:
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    week1.Add(new Day());
                    for (int i = 0; i < n; i += 1)
                    {
                        if (i < 1)
                        {
                            week1.Add(D[i]);
                        }
                        else if (i < 8)
                        {
                            week2.Add(D[i]);
                        }
                        else if (i < 15)
                        {
                            week3.Add(D[i]);
                        }
                        else if (i < 22)
                        {
                            week4.Add(D[i]);
                        }
                        else if (i < 29)
                        {
                            week5.Add(D[i]);
                        }
                        else
                        {
                            week6.Add(D[i]);
                        }
                    }
                    w1.Add(week1);
                    w2.Add(week2);
                    w3.Add(week3);
                    w4.Add(week4);
                    w5.Add(week5);
                    w6.Add(week6);
                    Weeks.Add(w1);
                    Weeks.Add(w2);
                    Weeks.Add(w3);
                    Weeks.Add(w4);
                    Weeks.Add(w5);
                    Weeks.Add(w6);
                    break;
            }
        }
    }
}
