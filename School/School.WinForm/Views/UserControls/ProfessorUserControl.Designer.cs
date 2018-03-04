namespace School.WinForm.Views.UserControls
{
    partial class ProfessorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblProfessorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblProfFirstName = new System.Windows.Forms.Label();
            this.txtProfFirstName = new System.Windows.Forms.TextBox();
            this.lblProfMiddleName = new System.Windows.Forms.Label();
            this.txtProfMiddleName = new System.Windows.Forms.TextBox();
            this.lblProfLastName = new System.Windows.Forms.Label();
            this.txtProfLastName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.tblProfessorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProfessorPanel
            // 
            this.tblProfessorPanel.ColumnCount = 2;
            this.tblProfessorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tblProfessorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tblProfessorPanel.Controls.Add(this.lblID, 0, 0);
            this.tblProfessorPanel.Controls.Add(this.txtID, 1, 0);
            this.tblProfessorPanel.Controls.Add(this.lblProfFirstName, 0, 1);
            this.tblProfessorPanel.Controls.Add(this.txtProfFirstName, 1, 1);
            this.tblProfessorPanel.Controls.Add(this.lblProfMiddleName, 0, 2);
            this.tblProfessorPanel.Controls.Add(this.txtProfMiddleName, 1, 2);
            this.tblProfessorPanel.Controls.Add(this.lblProfLastName, 0, 3);
            this.tblProfessorPanel.Controls.Add(this.txtProfLastName, 1, 3);
            this.tblProfessorPanel.Controls.Add(this.lblDepartment, 0, 4);
            this.tblProfessorPanel.Controls.Add(this.cboDepartment, 1, 4);
            this.tblProfessorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProfessorPanel.Location = new System.Drawing.Point(0, 0);
            this.tblProfessorPanel.Name = "tblProfessorPanel";
            this.tblProfessorPanel.RowCount = 5;
            this.tblProfessorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblProfessorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblProfessorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblProfessorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblProfessorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblProfessorPanel.Size = new System.Drawing.Size(241, 99);
            this.tblProfessorPanel.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(101, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(137, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblProfFirstName
            // 
            this.lblProfFirstName.AutoSize = true;
            this.lblProfFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfFirstName.Location = new System.Drawing.Point(3, 19);
            this.lblProfFirstName.Name = "lblProfFirstName";
            this.lblProfFirstName.Size = new System.Drawing.Size(92, 19);
            this.lblProfFirstName.TabIndex = 2;
            this.lblProfFirstName.Text = "First Name";
            // 
            // txtProfFirstName
            // 
            this.txtProfFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProfFirstName.Location = new System.Drawing.Point(101, 22);
            this.txtProfFirstName.Name = "txtProfFirstName";
            this.txtProfFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtProfFirstName.TabIndex = 3;
            // 
            // lblProfMiddleName
            // 
            this.lblProfMiddleName.AutoSize = true;
            this.lblProfMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfMiddleName.Location = new System.Drawing.Point(3, 38);
            this.lblProfMiddleName.Name = "lblProfMiddleName";
            this.lblProfMiddleName.Size = new System.Drawing.Size(92, 19);
            this.lblProfMiddleName.TabIndex = 5;
            this.lblProfMiddleName.Text = "Middle Name";
            // 
            // txtProfMiddleName
            // 
            this.txtProfMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProfMiddleName.Location = new System.Drawing.Point(101, 41);
            this.txtProfMiddleName.Name = "txtProfMiddleName";
            this.txtProfMiddleName.Size = new System.Drawing.Size(137, 20);
            this.txtProfMiddleName.TabIndex = 4;
            // 
            // lblProfLastName
            // 
            this.lblProfLastName.AutoSize = true;
            this.lblProfLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfLastName.Location = new System.Drawing.Point(3, 57);
            this.lblProfLastName.Name = "lblProfLastName";
            this.lblProfLastName.Size = new System.Drawing.Size(92, 19);
            this.lblProfLastName.TabIndex = 6;
            this.lblProfLastName.Text = "Last Name";
            // 
            // txtProfLastName
            // 
            this.txtProfLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProfLastName.Location = new System.Drawing.Point(101, 60);
            this.txtProfLastName.Name = "txtProfLastName";
            this.txtProfLastName.Size = new System.Drawing.Size(137, 20);
            this.txtProfLastName.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Location = new System.Drawing.Point(3, 76);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(92, 23);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(101, 79);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(137, 21);
            this.cboDepartment.TabIndex = 9;
            // 
            // ProfessorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProfessorPanel);
            this.Name = "ProfessorUserControl";
            this.Size = new System.Drawing.Size(241, 99);
            this.tblProfessorPanel.ResumeLayout(false);
            this.tblProfessorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblProfessorPanel;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblProfFirstName;
        public System.Windows.Forms.TextBox txtProfFirstName;
        public System.Windows.Forms.Label lblProfMiddleName;
        public System.Windows.Forms.TextBox txtProfMiddleName;
        public System.Windows.Forms.Label lblProfLastName;
        public System.Windows.Forms.TextBox txtProfLastName;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.ComboBox cboDepartment;
    }
}
