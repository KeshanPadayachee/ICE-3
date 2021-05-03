using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class frmViewTasks : Form
    {
        public frmViewTasks()
        {
            InitializeComponent();
        }

        private void frmViewTasks_Load(object sender, EventArgs e)
        {
            Task viewTask = new Task();
            rTxbViewTasks.AppendText(viewTask.viewTasks());
        }
    }
}
