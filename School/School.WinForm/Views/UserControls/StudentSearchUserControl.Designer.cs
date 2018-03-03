namespace School.WinForm.Views.UserControls
{
    partial class StudentSearchUserControl
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
            this.pnlStudentsSearch = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudLastName = new System.Windows.Forms.TextBox();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.pnlStudentsGrid = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlStudentsSearch.SuspendLayout();
            this.pnlStudentsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentsSearch
            // 
            this.pnlStudentsSearch.Controls.Add(this.btnAdd);
            this.pnlStudentsSearch.Controls.Add(this.btnSearch);
            this.pnlStudentsSearch.Controls.Add(this.txtStudLastName);
            this.pnlStudentsSearch.Controls.Add(this.lblStudentLastName);
            this.pnlStudentsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentsSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentsSearch.Name = "pnlStudentsSearch";
            this.pnlStudentsSearch.Size = new System.Drawing.Size(970, 23);
            this.pnlStudentsSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(438, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(363, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudLastName
            // 
            this.txtStudLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStudLastName.Location = new System.Drawing.Point(143, 0);
            this.txtStudLastName.Name = "txtStudLastName";
            this.txtStudLastName.Size = new System.Drawing.Size(220, 22);
            this.txtStudLastName.TabIndex = 1;
            this.txtStudLastName.TextChanged += new System.EventHandler(this.txtStudLastName_TextChanged);
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStudentLastName.Location = new System.Drawing.Point(0, 0);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(143, 17);
            this.lblStudentLastName.TabIndex = 0;
            this.lblStudentLastName.Text = "Student\'s Last Name:";
            // 
            // pnlStudentsGrid
            // 
            this.pnlStudentsGrid.Controls.Add(this.dgvStudents);
            this.pnlStudentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentsGrid.Location = new System.Drawing.Point(0, 23);
            this.pnlStudentsGrid.Name = "pnlStudentsGrid";
            this.pnlStudentsGrid.Size = new System.Drawing.Size(970, 488);
            this.pnlStudentsGrid.TabIndex = 1;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colStudFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colDepartment,
            this.colEdit,
            this.colDelete});
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(970, 488);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colStudFirstName
            // 
            this.colStudFirstName.HeaderText = "First Name";
            this.colStudFirstName.Name = "colStudFirstName";
            this.colStudFirstName.ReadOnly = true;
            this.colStudFirstName.Width = 150;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "Middle Name";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            this.colMiddleName.Width = 150;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 150;
            // 
            // colDepartment
            // 
            this.colDepartment.FillWeight = 150F;
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // StudentSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlStudentsGrid);
            this.Controls.Add(this.pnlStudentsSearch);
            this.Name = "StudentSearchUserControl";
            this.Size = new System.Drawing.Size(970, 511);
            this.pnlStudentsSearch.ResumeLayout(false);
            this.pnlStudentsSearch.PerformLayout();
            this.pnlStudentsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentsSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudLastName;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.Panel pnlStudentsGrid;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
