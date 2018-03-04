namespace School.WinForm.Views.UserControls
{
    partial class StudentUserControl
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
            this.tblStudentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtStudMiddleName = new System.Windows.Forms.TextBox();
            this.txtStudLastName = new System.Windows.Forms.TextBox();
            this.txtStudFirstName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStudFirtsName = new System.Windows.Forms.Label();
            this.lblStudLastName = new System.Windows.Forms.Label();
            this.lblStudMiddleName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.tblStudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblStudentPanel
            // 
            this.tblStudentPanel.ColumnCount = 2;
            this.tblStudentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblStudentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblStudentPanel.Controls.Add(this.txtStudMiddleName, 1, 3);
            this.tblStudentPanel.Controls.Add(this.txtStudLastName, 1, 2);
            this.tblStudentPanel.Controls.Add(this.txtStudFirstName, 1, 1);
            this.tblStudentPanel.Controls.Add(this.lblID, 0, 0);
            this.tblStudentPanel.Controls.Add(this.lblStudFirtsName, 0, 1);
            this.tblStudentPanel.Controls.Add(this.lblStudLastName, 0, 2);
            this.tblStudentPanel.Controls.Add(this.lblStudMiddleName, 0, 3);
            this.tblStudentPanel.Controls.Add(this.lblDepartment, 0, 4);
            this.tblStudentPanel.Controls.Add(this.txtID, 1, 0);
            this.tblStudentPanel.Controls.Add(this.cboDepartment, 1, 4);
            this.tblStudentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudentPanel.Location = new System.Drawing.Point(0, 0);
            this.tblStudentPanel.Name = "tblStudentPanel";
            this.tblStudentPanel.RowCount = 5;
            this.tblStudentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStudentPanel.Size = new System.Drawing.Size(253, 116);
            this.tblStudentPanel.TabIndex = 0;
            // 
            // txtStudMiddleName
            // 
            this.txtStudMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudMiddleName.Location = new System.Drawing.Point(104, 72);
            this.txtStudMiddleName.Multiline = true;
            this.txtStudMiddleName.Name = "txtStudMiddleName";
            this.txtStudMiddleName.Size = new System.Drawing.Size(146, 17);
            this.txtStudMiddleName.TabIndex = 8;
            // 
            // txtStudLastName
            // 
            this.txtStudLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudLastName.Location = new System.Drawing.Point(104, 49);
            this.txtStudLastName.Multiline = true;
            this.txtStudLastName.Name = "txtStudLastName";
            this.txtStudLastName.Size = new System.Drawing.Size(146, 17);
            this.txtStudLastName.TabIndex = 7;
            // 
            // txtStudFirstName
            // 
            this.txtStudFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudFirstName.Location = new System.Drawing.Point(104, 26);
            this.txtStudFirstName.Multiline = true;
            this.txtStudFirstName.Name = "txtStudFirstName";
            this.txtStudFirstName.Size = new System.Drawing.Size(146, 17);
            this.txtStudFirstName.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblStudFirtsName
            // 
            this.lblStudFirtsName.AutoSize = true;
            this.lblStudFirtsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudFirtsName.Location = new System.Drawing.Point(3, 23);
            this.lblStudFirtsName.Name = "lblStudFirtsName";
            this.lblStudFirtsName.Size = new System.Drawing.Size(95, 23);
            this.lblStudFirtsName.TabIndex = 1;
            this.lblStudFirtsName.Text = "First Name";
            // 
            // lblStudLastName
            // 
            this.lblStudLastName.AutoSize = true;
            this.lblStudLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudLastName.Location = new System.Drawing.Point(3, 46);
            this.lblStudLastName.Name = "lblStudLastName";
            this.lblStudLastName.Size = new System.Drawing.Size(95, 23);
            this.lblStudLastName.TabIndex = 2;
            this.lblStudLastName.Text = "Last Name";
            // 
            // lblStudMiddleName
            // 
            this.lblStudMiddleName.AutoSize = true;
            this.lblStudMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudMiddleName.Location = new System.Drawing.Point(3, 69);
            this.lblStudMiddleName.Name = "lblStudMiddleName";
            this.lblStudMiddleName.Size = new System.Drawing.Size(95, 23);
            this.lblStudMiddleName.TabIndex = 3;
            this.lblStudMiddleName.Text = "Middle Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Location = new System.Drawing.Point(3, 92);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(95, 24);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(104, 3);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(146, 17);
            this.txtID.TabIndex = 5;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(104, 95);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(146, 21);
            this.cboDepartment.TabIndex = 9;
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblStudentPanel);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(253, 116);
            this.tblStudentPanel.ResumeLayout(false);
            this.tblStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblStudentPanel;
        public System.Windows.Forms.TextBox txtStudMiddleName;
        public System.Windows.Forms.TextBox txtStudLastName;
        public System.Windows.Forms.TextBox txtStudFirstName;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblStudFirtsName;
        public System.Windows.Forms.Label lblStudLastName;
        public System.Windows.Forms.Label lblStudMiddleName;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ComboBox cboDepartment;
    }
}
