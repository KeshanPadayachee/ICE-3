
namespace ToDoList
{
    partial class frmViewTasks
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
            this.rTxbViewTasks = new System.Windows.Forms.RichTextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTxbViewTasks
            // 
            this.rTxbViewTasks.Location = new System.Drawing.Point(21, 66);
            this.rTxbViewTasks.Name = "rTxbViewTasks";
            this.rTxbViewTasks.ReadOnly = true;
            this.rTxbViewTasks.Size = new System.Drawing.Size(535, 449);
            this.rTxbViewTasks.TabIndex = 0;
            this.rTxbViewTasks.Text = "";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(235, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(109, 28);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "My Tasks: ";
            // 
            // frmViewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 527);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.rTxbViewTasks);
            this.Name = "frmViewTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewTasks";
            this.Load += new System.EventHandler(this.frmViewTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxbViewTasks;
        private System.Windows.Forms.Label lblHeading;
    }
}