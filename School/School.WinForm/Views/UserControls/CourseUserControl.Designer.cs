namespace School.WinForm.Views.UserControls
{
    partial class CourseUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tblCoursePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.cboCredits = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.tblCoursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(2, 0);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(104, 2);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 1;
            // 
            // tblCoursePanel
            // 
            this.tblCoursePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCoursePanel.ColumnCount = 2;
            this.tblCoursePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tblCoursePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tblCoursePanel.Controls.Add(this.txtID, 1, 0);
            this.tblCoursePanel.Controls.Add(this.lblID, 0, 0);
            this.tblCoursePanel.Controls.Add(this.lblCourseNumber, 0, 2);
            this.tblCoursePanel.Controls.Add(this.txtCourseNumber, 1, 2);
            this.tblCoursePanel.Controls.Add(this.lblCourseName, 0, 3);
            this.tblCoursePanel.Controls.Add(this.txtCourseName, 1, 3);
            this.tblCoursePanel.Controls.Add(this.lblCourseDescription, 0, 4);
            this.tblCoursePanel.Controls.Add(this.txtCourseDescription, 1, 4);
            this.tblCoursePanel.Controls.Add(this.lblCredits, 0, 5);
            this.tblCoursePanel.Controls.Add(this.cboCredits, 1, 5);
            this.tblCoursePanel.Controls.Add(this.lblDepartment, 0, 1);
            this.tblCoursePanel.Controls.Add(this.cboDepartment, 1, 1);
            this.tblCoursePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCoursePanel.Location = new System.Drawing.Point(0, 0);
            this.tblCoursePanel.Margin = new System.Windows.Forms.Padding(2);
            this.tblCoursePanel.Name = "tblCoursePanel";
            this.tblCoursePanel.RowCount = 6;
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblCoursePanel.Size = new System.Drawing.Size(250, 124);
            this.tblCoursePanel.TabIndex = 2;
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseNumber.Location = new System.Drawing.Point(2, 40);
            this.lblCourseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(98, 20);
            this.lblCourseNumber.TabIndex = 2;
            this.lblCourseNumber.Text = "Course Number";
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseNumber.Location = new System.Drawing.Point(104, 42);
            this.txtCourseNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(144, 20);
            this.txtCourseNumber.TabIndex = 3;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseName.Location = new System.Drawing.Point(2, 60);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(98, 20);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseName.Location = new System.Drawing.Point(104, 62);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(144, 20);
            this.txtCourseName.TabIndex = 5;
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourseDescription.Location = new System.Drawing.Point(2, 80);
            this.lblCourseDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(98, 20);
            this.lblCourseDescription.TabIndex = 6;
            this.lblCourseDescription.Text = "Course Description";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCourseDescription.Location = new System.Drawing.Point(104, 82);
            this.txtCourseDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(144, 20);
            this.txtCourseDescription.TabIndex = 7;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredits.Location = new System.Drawing.Point(2, 100);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(98, 24);
            this.lblCredits.TabIndex = 8;
            this.lblCredits.Text = "Credits";
            // 
            // cboCredits
            // 
            this.cboCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCredits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCredits.FormattingEnabled = true;
            this.cboCredits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboCredits.Location = new System.Drawing.Point(104, 102);
            this.cboCredits.Margin = new System.Windows.Forms.Padding(2);
            this.cboCredits.Name = "cboCredits";
            this.cboCredits.Size = new System.Drawing.Size(144, 21);
            this.cboCredits.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Location = new System.Drawing.Point(2, 20);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(98, 20);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(104, 22);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(144, 21);
            this.cboDepartment.TabIndex = 11;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // CourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCoursePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseUserControl";
            this.Size = new System.Drawing.Size(250, 124);
            this.tblCoursePanel.ResumeLayout(false);
            this.tblCoursePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TableLayoutPanel tblCoursePanel;
        public System.Windows.Forms.Label lblCourseNumber;
        public System.Windows.Forms.TextBox txtCourseNumber;
        public System.Windows.Forms.Label lblCourseName;
        public System.Windows.Forms.TextBox txtCourseName;
        public System.Windows.Forms.Label lblCourseDescription;
        public System.Windows.Forms.TextBox txtCourseDescription;
        public System.Windows.Forms.Label lblCredits;
        public System.Windows.Forms.ComboBox cboCredits;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.ComboBox cboDepartment;
    }
}
