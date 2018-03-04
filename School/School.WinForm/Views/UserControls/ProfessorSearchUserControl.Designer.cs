namespace School.WinForm.Views.UserControls
{
    partial class ProfessorSearchUserControl
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
            this.pnlProfessorsSearch = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProfLastName = new System.Windows.Forms.TextBox();
            this.lblProfLastName = new System.Windows.Forms.Label();
            this.pnlProfessorsGrid = new System.Windows.Forms.Panel();
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlProfessorsSearch.SuspendLayout();
            this.pnlProfessorsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProfessorsSearch
            // 
            this.pnlProfessorsSearch.Controls.Add(this.btnAdd);
            this.pnlProfessorsSearch.Controls.Add(this.btnSearch);
            this.pnlProfessorsSearch.Controls.Add(this.txtProfLastName);
            this.pnlProfessorsSearch.Controls.Add(this.lblProfLastName);
            this.pnlProfessorsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfessorsSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlProfessorsSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlProfessorsSearch.Name = "pnlProfessorsSearch";
            this.pnlProfessorsSearch.Size = new System.Drawing.Size(728, 19);
            this.pnlProfessorsSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(321, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(265, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProfLastName
            // 
            this.txtProfLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtProfLastName.Location = new System.Drawing.Point(112, 0);
            this.txtProfLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfLastName.Name = "txtProfLastName";
            this.txtProfLastName.Size = new System.Drawing.Size(153, 20);
            this.txtProfLastName.TabIndex = 1;
            this.txtProfLastName.TextChanged += new System.EventHandler(this.txtProfLastName_TextChanged);
            // 
            // lblProfLastName
            // 
            this.lblProfLastName.AutoSize = true;
            this.lblProfLastName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProfLastName.Location = new System.Drawing.Point(0, 0);
            this.lblProfLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfLastName.Name = "lblProfLastName";
            this.lblProfLastName.Size = new System.Drawing.Size(112, 13);
            this.lblProfLastName.TabIndex = 0;
            this.lblProfLastName.Text = "Professor\'s Last Name";
            // 
            // pnlProfessorsGrid
            // 
            this.pnlProfessorsGrid.Controls.Add(this.dgvProfessors);
            this.pnlProfessorsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfessorsGrid.Location = new System.Drawing.Point(0, 19);
            this.pnlProfessorsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlProfessorsGrid.Name = "pnlProfessorsGrid";
            this.pnlProfessorsGrid.Size = new System.Drawing.Size(728, 396);
            this.pnlProfessorsGrid.TabIndex = 1;
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.AllowUserToAddRows = false;
            this.dgvProfessors.AllowUserToDeleteRows = false;
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProfFirstName,
            this.colProfMiddleName,
            this.colProLastName,
            this.colDepartment,
            this.colEdit,
            this.colDelete});
            this.dgvProfessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfessors.Location = new System.Drawing.Point(0, 0);
            this.dgvProfessors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.ReadOnly = true;
            this.dgvProfessors.RowTemplate.Height = 24;
            this.dgvProfessors.Size = new System.Drawing.Size(728, 396);
            this.dgvProfessors.TabIndex = 0;
            this.dgvProfessors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessors_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colProfFirstName
            // 
            this.colProfFirstName.HeaderText = "First Name";
            this.colProfFirstName.Name = "colProfFirstName";
            this.colProfFirstName.ReadOnly = true;
            this.colProfFirstName.Width = 150;
            // 
            // colProfMiddleName
            // 
            this.colProfMiddleName.HeaderText = "Middle Name";
            this.colProfMiddleName.Name = "colProfMiddleName";
            this.colProfMiddleName.ReadOnly = true;
            this.colProfMiddleName.Width = 150;
            // 
            // colProLastName
            // 
            this.colProLastName.HeaderText = "Last Name";
            this.colProLastName.Name = "colProLastName";
            this.colProLastName.ReadOnly = true;
            this.colProLastName.Width = 150;
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Width = 150;
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
            // ProfessorSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlProfessorsGrid);
            this.Controls.Add(this.pnlProfessorsSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProfessorSearchUserControl";
            this.Size = new System.Drawing.Size(728, 415);
            this.pnlProfessorsSearch.ResumeLayout(false);
            this.pnlProfessorsSearch.PerformLayout();
            this.pnlProfessorsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfessorsSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProfLastName;
        private System.Windows.Forms.Label lblProfLastName;
        private System.Windows.Forms.Panel pnlProfessorsGrid;
        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
