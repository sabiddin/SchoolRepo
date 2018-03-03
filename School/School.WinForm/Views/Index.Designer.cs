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
            this.pageDepartments = new System.Windows.Forms.TabPage();
            this.pageCourses = new System.Windows.Forms.TabPage();
            this.pageStudents = new System.Windows.Forms.TabPage();
            this.pageProfessors = new System.Windows.Forms.TabPage();
            this.tabIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIndex
            // 
            this.tabIndex.Controls.Add(this.pageDepartments);
            this.tabIndex.Controls.Add(this.pageCourses);
            this.tabIndex.Controls.Add(this.pageStudents);
            this.tabIndex.Controls.Add(this.pageProfessors);
            this.tabIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabIndex.Location = new System.Drawing.Point(0, 0);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.SelectedIndex = 0;
            this.tabIndex.Size = new System.Drawing.Size(970, 593);
            this.tabIndex.TabIndex = 0;
            // 
            // pageDepartments
            // 
            this.pageDepartments.Location = new System.Drawing.Point(4, 25);
            this.pageDepartments.Name = "pageDepartments";
            this.pageDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.pageDepartments.Size = new System.Drawing.Size(962, 564);
            this.pageDepartments.TabIndex = 0;
            this.pageDepartments.Text = "Departments";
            this.pageDepartments.UseVisualStyleBackColor = true;
            // 
            // pageCourses
            // 
            this.pageCourses.Location = new System.Drawing.Point(4, 25);
            this.pageCourses.Name = "pageCourses";
            this.pageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.pageCourses.Size = new System.Drawing.Size(962, 564);
            this.pageCourses.TabIndex = 1;
            this.pageCourses.Text = "Courses";
            this.pageCourses.UseVisualStyleBackColor = true;
            // 
            // pageStudents
            // 
            this.pageStudents.Location = new System.Drawing.Point(4, 25);
            this.pageStudents.Name = "pageStudents";
            this.pageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.pageStudents.Size = new System.Drawing.Size(962, 564);
            this.pageStudents.TabIndex = 2;
            this.pageStudents.Text = "Students";
            this.pageStudents.UseVisualStyleBackColor = true;
            // 
            // pageProfessors
            // 
            this.pageProfessors.Location = new System.Drawing.Point(4, 25);
            this.pageProfessors.Name = "pageProfessors";
            this.pageProfessors.Size = new System.Drawing.Size(962, 564);
            this.pageProfessors.TabIndex = 3;
            this.pageProfessors.Text = "Professors";
            this.pageProfessors.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage pageDepartments;
        private System.Windows.Forms.TabPage pageCourses;
        private System.Windows.Forms.TabPage pageStudents;
        private System.Windows.Forms.TabPage pageProfessors;
    }
}