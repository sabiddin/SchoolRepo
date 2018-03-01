namespace School.WinForm.Views.CourseViews
{
    partial class CourseRead
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
            this.pnlSearchCourses = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSearchCourses
            // 
            this.pnlSearchCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchCourses.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchCourses.Name = "pnlSearchCourses";
            this.pnlSearchCourses.Size = new System.Drawing.Size(1248, 649);
            this.pnlSearchCourses.TabIndex = 2;
            // 
            // CourseRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 649);
            this.Controls.Add(this.pnlSearchCourses);
            this.Name = "CourseRead";
            this.Text = "Course Read";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearchCourses;
    }
}