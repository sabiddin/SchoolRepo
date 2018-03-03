namespace School.WinForm.Views.UserControls
{
    partial class DepartmentSearchUserControl
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
            this.pnlSearchDepartments = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.pnlDepartmentsGrid = new System.Windows.Forms.Panel();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlSearchDepartments.SuspendLayout();
            this.pnlDepartmentsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchDepartments
            // 
            this.pnlSearchDepartments.Controls.Add(this.btnAdd);
            this.pnlSearchDepartments.Controls.Add(this.btnSearch);
            this.pnlSearchDepartments.Controls.Add(this.txtDepartmentName);
            this.pnlSearchDepartments.Controls.Add(this.lblDepartmentName);
            this.pnlSearchDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchDepartments.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchDepartments.Name = "pnlSearchDepartments";
            this.pnlSearchDepartments.Size = new System.Drawing.Size(970, 23);
            this.pnlSearchDepartments.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(433, 0);
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
            this.btnSearch.Location = new System.Drawing.Point(358, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDepartmentName.Location = new System.Drawing.Point(127, 0);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(231, 22);
            this.txtDepartmentName.TabIndex = 1;
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDepartmentName.Location = new System.Drawing.Point(0, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(127, 17);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // pnlDepartmentsGrid
            // 
            this.pnlDepartmentsGrid.Controls.Add(this.dgvDepartments);
            this.pnlDepartmentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepartmentsGrid.Location = new System.Drawing.Point(0, 23);
            this.pnlDepartmentsGrid.Name = "pnlDepartmentsGrid";
            this.pnlDepartmentsGrid.Size = new System.Drawing.Size(970, 488);
            this.pnlDepartmentsGrid.TabIndex = 1;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDepartmentCode,
            this.colDepartmentDescription,
            this.colEdit,
            this.colDelete});
            this.dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartments.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(970, 488);
            this.dgvDepartments.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 200;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.HeaderText = "Code";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.ReadOnly = true;
            this.colDepartmentCode.Width = 200;
            // 
            // colDepartmentDescription
            // 
            this.colDepartmentDescription.HeaderText = "Description";
            this.colDepartmentDescription.Name = "colDepartmentDescription";
            this.colDepartmentDescription.ReadOnly = true;
            this.colDepartmentDescription.Width = 400;
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
            // DepartmentSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlDepartmentsGrid);
            this.Controls.Add(this.pnlSearchDepartments);
            this.Name = "DepartmentSearchUserControl";
            this.Size = new System.Drawing.Size(970, 511);
            this.pnlSearchDepartments.ResumeLayout(false);
            this.pnlSearchDepartments.PerformLayout();
            this.pnlDepartmentsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchDepartments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Panel pnlDepartmentsGrid;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
