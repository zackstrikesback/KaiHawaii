using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCalendar.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows;

namespace ProjectCalendar.ViewModel
{
    public class MasterViewModel
    {
        public MyICommand DeleteCommand { get; set; }  //Deletes Project
        public MyICommand AddCommand { get; set; }  //Adds Employee to Project
        public MyICommand RemoveCommand { get; set; }  //Removes Employee from Project
        public MyICommand TDeleteCommand { get; set; }  //Deletes Task from Project
        public MyICommand TAddCommand { get; set; }  //Adds Employee to Task
        public MyICommand TRemoveCommand { get; set; }  //Removes Employee from Task

        public ProjViewModel Proj { get; set; }
        public PersonViewModel Person { get; set; }
        //Loads current Project list and Employee list
        public MasterViewModel()
        {
            this.Proj = new ProjViewModel();
            this.Person = new PersonViewModel();
            Proj.Load();
            Person.Load();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            AddCommand = new MyICommand(OnAdd, CanAdd);
            RemoveCommand = new MyICommand(OnRemove, CanRemove);
            TDeleteCommand = new MyICommand(TOnDelete, TCanDelete);
            TAddCommand = new MyICommand(TOnAdd, TCanAdd);
            TRemoveCommand = new MyICommand(TOnRemove, TCanRemove);
        }

        private Project _selectedProject;
        private Person _selectedPerson;
        private string _selectedRemove;
        //User Selected Project from Project list
        public Project SelectedProject
        {
            get
            {
                return _selectedProject;
            }
            set
            {
                _selectedProject = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }
        //User Selected Employee from Employee list combobox
        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                AddCommand.RaiseCanExecuteChanged();
            }
        }
        //User Selected Employee from Assigned Employee list
        public string SelectedRemove
        {
            get
            {
                return _selectedRemove;
            }
            set
            {
                _selectedRemove = value;
                RemoveCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnDelete()
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Proj.Projects.Remove(SelectedProject);
            }
            else
            {
                System.Windows.MessageBox.Show("Delete operation Terminated");
            }          
        }

        private bool CanDelete()
        {
            return SelectedProject != null;
        }

        private void OnAdd()
        {
            int i = Proj.Projects.IndexOf(SelectedProject);
            if (!Proj.Projects[i].Assigned.Contains(SelectedPerson.Email))
            {
                Proj.Projects[i].Assigned.Add(SelectedPerson.Email);
            }
        }

        private bool CanAdd()
        {
            return SelectedPerson != null;
        }

        private void OnRemove()
        {
            int i = Proj.Projects.IndexOf(SelectedProject);
            Proj.Projects[i].Assigned.Remove(SelectedRemove);
        }

        private bool CanRemove()
        {
            return SelectedRemove != null;
        }

        private ProjectTask _selectedTask;
        private string _selectedTPerson;
        private string _selectedTRemove;
        //User Selected Task from Task list
        public ProjectTask SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                _selectedTask = value;
                TDeleteCommand.RaiseCanExecuteChanged();
            }
        }
        //User Selected Employee from Employee list combobox for tasks
        public string TSelectedPerson
        {
            get
            {
                return _selectedTPerson;
            }
            set
            {
                _selectedTPerson = value;
                TAddCommand.RaiseCanExecuteChanged();
            }
        }
        //User Selected Employee from Assigned Employee list for tasks
        public string TSelectedRemove
        {
            get
            {
                return _selectedTRemove;
            }
            set
            {
                _selectedTRemove = value;
                TRemoveCommand.RaiseCanExecuteChanged();
            }
        }

        private void TOnDelete()
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int i = Proj.Projects.IndexOf(SelectedProject);
                Proj.Projects[i].Tasks.Remove(SelectedTask);
            }
            else
            {
                System.Windows.MessageBox.Show("Delete operation Terminated");
            }
        }

        private bool TCanDelete()
        {
            return SelectedProject != null;
        }

        private void TOnAdd()
        {
            int i = Proj.Projects.IndexOf(SelectedProject);
            int t = Proj.Projects[i].Tasks.IndexOf(SelectedTask);
            if (!Proj.Projects[i].Tasks[t].Assigned.Contains(TSelectedPerson))
            {
                Proj.Projects[i].Tasks[t].Assigned.Add(TSelectedPerson);
            }
        }

        private bool TCanAdd()
        {
            return TSelectedPerson != null;
        }

        private void TOnRemove()
        {
            int i = Proj.Projects.IndexOf(SelectedProject);
            int t = Proj.Projects[i].Tasks.IndexOf(SelectedTask);
            Proj.Projects[i].Tasks[t].Assigned.Remove(TSelectedRemove);
        }

        private bool TCanRemove()
        {
            return TSelectedRemove != null;
        }
    }
}
