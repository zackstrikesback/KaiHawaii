using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCalendar.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using System.Windows;

namespace ProjectCalendar.ViewModel
{
    public class ProjViewModel
    {
        public ObservableCollection<Project> Projects
        {
            get;
            set;
        }
        //Loads current projects from text file.
        public void Load()
        {
            List<Project> p = Reader();
            ObservableCollection<Project> projects = new ObservableCollection<Project>(p as List<Project>);
            Projects = projects;
        }
        //Adds a project to current projects if it does not exist.
        public void AddProject(Project p)
        {
            if (!Projects.Contains(p))
            {
                Projects.Add(p);
            }
            else
            {
                MessageBox.Show("Project already Exists");
            }
        }
        //Adds a task to a project if it does not exist.
        public void AddTask(Project ps, ProjectTask t)
        {
            if (!ps.Tasks.Contains(t))
            {
                ps.Tasks.Add(t);
            }
            else
            {
                MessageBox.Show("Task already Exists");
            }
        }
        //Reads myProjects.txt in current directory.  If myProjects.txt does not
        //exist it creates a blank text file.  Sets application user from first line of text file.
        public static List<Project> Reader()
        {
            List<Project> projects = new List<Project>();
            Project proj = null;
            ProjectTask task;
            string path = MainWindow.file;
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                line = sr.ReadLine();
                if(line != null)
                {
                    String[] per = line.Split(new string[] { "**" }, StringSplitOptions.None);
                    Person pers = new Person(per[0], per[1], per[2]);
                    MainWindow.user = pers;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "+++")
                    {
                        projects.Add(proj);
                        continue;
                    }
                    else if (line.StartsWith("**"))
                    {
                        List<string> a = new List<string>();
                        String[] t = line.Split(new string[] { "**" }, StringSplitOptions.None);
                        if (!t[3].Contains(","))
                        {
                            a.Add(t[3]);
                        }
                        else
                        {
                            a = t[3].Split(',').ToList();
                        }
                        DateTime d = Convert.ToDateTime(t[4]);
                        ObservableCollection<String> AO = new ObservableCollection<String>(a as List<String>);
                        task = new ProjectTask(t[1], t[2], AO, d);
                        proj.Tasks.Add(task);
                    }
                    else
                    {
                        ObservableCollection<ProjectTask> ts = new ObservableCollection<ProjectTask>();
                        List<string> a = new List<string>();
                        String[] p = line.Split(new string[] { "**" }, StringSplitOptions.None);
                        if (!p[2].Contains(","))
                        {
                            a.Add(p[2]);
                        }
                        else
                        {
                            a = p[2].Split(',').ToList();
                        }
                        ObservableCollection<String> AO = new ObservableCollection<String>(a as List<String>);
                        proj = new Project(p[0], p[1], AO, ts);
                    }
                }
            }
            return projects;
        }
    }
}
