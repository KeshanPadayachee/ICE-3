using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmAddTask : Form
    {
        public frmAddTask()
        {
            InitializeComponent();
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
            string taskName;
            string taskDesc;
            DateTime completeDate;
            string priority;

            taskName = txbTaskName.Text;
            taskDesc = txbTaskDesc.Text;
            completeDate = dTCompleteBy.Value;
            int priorityIndex = cmbPriority.SelectedIndex;
            switch (priorityIndex)
            {
                case 0: priority = "Low Priority";
                    break;
                case 1: priority = "Medium Priority";
                    break;
                case 2: priority = "High Priority";
                    break;
                case 3: priority = "Urgent";
                    break;
                default: priority = "N/A";
                    break;
            } // End of switch statement

            Task addTask = new Task(taskName,taskDesc,completeDate,DateTime.Now,priority);
            addTask.addNewTask();
            txbTaskName.Clear();
            txbTaskDesc.Clear();
            dTCompleteBy.Value = DateTime.Now;
            cmbPriority.SelectedIndex = 0;
        }
    }
}
