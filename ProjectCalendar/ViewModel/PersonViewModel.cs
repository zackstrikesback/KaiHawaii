using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCalendar.Models;
using System.Collections.ObjectModel;
using System.IO;

namespace ProjectCalendar.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> Persons
        {
            get;
            set;
        }
        //Loads EmployeeList.csv
        public void Load()
        {
            List<Person> p = ReadCSV("EmployeeList").ToList<Person>();
            ObservableCollection<Person> persons = new ObservableCollection<Person>(p as List<Person>);
            Persons = persons;
        }
        //Reads CSV file stored in current directory Resources folder.
        //CSV file format: FirstName,LastName,Email
        public IEnumerable<Person> ReadCSV(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources\", fileName);
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(path, ".csv"));
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new Person(data[0], data[1], data[2]);
            });
        }
    }
}
