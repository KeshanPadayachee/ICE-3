using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewTasks view = new frmViewTasks();
            view.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTask addTask = new frmAddTask();
            addTask.Show();
        }
    }
}
