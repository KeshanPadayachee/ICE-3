using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToDoList
{
    class Task
    {
        // Declaration of private variables
        private string taskName;
        private string description;
        private DateTime dateComplete;
        private DateTime dateAdded;
        private string priority;

        public Task()
        {

        }

        // Constructor to recieve values for the variables
        public Task(string taskName, string description, DateTime dateComplete, DateTime dateAdded,
            string priority)
        {
            this.taskName = taskName;
            this.description = description;
            this.dateComplete = dateComplete;
            this.dateAdded = dateAdded;
            this.priority = priority;
        }

        // Getter methods to access the values
        public string TaskName { get => taskName; }
        public string Description { get => description; }
        public DateTime DateComplete { get => dateComplete; }
        public DateTime DateAdded { get => dateAdded; }
        public string Priority { get => priority; }


        public void addNewTask()
        {
            try
            {
                StreamWriter addTask = new StreamWriter("Tasks.txt", true);
                string line = taskName + "#" + Description + "#" + DateComplete + "#" + DateAdded +
                    "#" + Priority;

                addTask.WriteLine(line);
                addTask.Close();
                MessageBox.Show("Task added successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find file Tasks.txt");
            }
        }

        public string viewTasks()
        {
            string output = "";
            try
            {
                StreamReader readTasks = new StreamReader("Tasks.txt");
                string line;
                while ((line = readTasks.ReadLine()) != null)
                {

                    string[] taskParts = line.Split("#");
                    output += "Task: " + taskParts[0] + "\n";
                    output += "Description: " + taskParts[1] + "\n";
                    string[] complete = taskParts[2].Split("/");
                    string year = complete[0];
                    string month = complete[1];
                    string day = complete[2].Substring(0, 2);
                    output += "Complete By: " + year + "/" + month + "/" + day + "\n";
                    string[] added = taskParts[3].Split("/");
                    year = added[0];
                    month = added[1];
                    day = added[2].Substring(0, 2);
                    output += "Added: " + year + "/" + month + "/" + day + "\n";
                    output += "Priority: " + taskParts[4] + "\n";
                    output += "\n";


                }
                readTasks.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find the file Tasks.txt");
            }
            return output;
        }
    }
}
