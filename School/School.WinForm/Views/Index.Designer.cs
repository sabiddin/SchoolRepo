namespace School.WinForm.Views
{
    partial class Index
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
            this.tabIndex = new System.Windows.Forms.TabControl();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.tabIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIndex
            // 
            this.tabIndex.Controls.Add(this.tabDepartments);
            this.tabIndex.Controls.Add(this.tabCourses);
            this.tabIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabIndex.Location = new System.Drawing.Point(0, 0);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.SelectedIndex = 0;
            this.tabIndex.Size = new System.Drawing.Size(970, 593);
            this.tabIndex.TabIndex = 0;
            // 
            // tabDepartments
            // 
            this.tabDepartments.Location = new System.Drawing.Point(4, 25);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(962, 564);
            this.tabDepartments.TabIndex = 0;
            this.tabDepartments.Text = "Departments";
            this.tabDepartments.UseVisualStyleBackColor = true;
            // 
            // tabCourses
            // 
            this.tabCourses.Location = new System.Drawing.Point(4, 25);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(192, 71);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 593);
            this.Controls.Add(this.tabIndex);
            this.Name = "Index";
            this.Text = "Index";            
            this.tabIndex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIndex;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabCourses;
    }
}