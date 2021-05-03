
namespace ToDoList
{
    partial class frmAddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTCompleteBy = new System.Windows.Forms.DateTimePicker();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.txbTaskDesc = new System.Windows.Forms.TextBox();
            this.txbTaskName = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Description: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complete By: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority: ";
            // 
            // dTCompleteBy
            // 
            this.dTCompleteBy.Location = new System.Drawing.Point(173, 234);
            this.dTCompleteBy.Name = "dTCompleteBy";
            this.dTCompleteBy.Size = new System.Drawing.Size(250, 27);
            this.dTCompleteBy.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low Priority",
            "Medium Priority",
            "High Priority",
            "Urgent"});
            this.cmbPriority.Location = new System.Drawing.Point(173, 299);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(151, 28);
            this.cmbPriority.TabIndex = 5;
            // 
            // txbTaskDesc
            // 
            this.txbTaskDesc.Location = new System.Drawing.Point(173, 172);
            this.txbTaskDesc.Multiline = true;
            this.txbTaskDesc.Name = "txbTaskDesc";
            this.txbTaskDesc.Size = new System.Drawing.Size(250, 34);
            this.txbTaskDesc.TabIndex = 6;
            // 
            // txbTaskName
            // 
            this.txbTaskName.Location = new System.Drawing.Point(173, 108);
            this.txbTaskName.Name = "txbTaskName";
            this.txbTaskName.Size = new System.Drawing.Size(151, 27);
            this.txbTaskName.TabIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(344, 368);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(132, 39);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(185, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(117, 28);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Add A Task";
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 419);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txbTaskName);
            this.Controls.Add(this.txbTaskDesc);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.dTCompleteBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddTask";
            this.Load += new System.EventHandler(this.frmAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTCompleteBy;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.TextBox txbTaskDesc;
        private System.Windows.Forms.TextBox txbTaskName;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblHeading;
    }
}