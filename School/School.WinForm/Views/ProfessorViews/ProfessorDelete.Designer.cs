namespace School.WinForm.Views.ProfessorViews
{
    partial class ProfessorDelete
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
            this.pnlProfessorUserControl = new System.Windows.Forms.Panel();
            this.ucProfessor = new School.WinForm.Views.UserControls.ProfessorUserControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlProfessorUserControl.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfessorUserControl
            // 
            this.pnlProfessorUserControl.Controls.Add(this.ucProfessor);
            this.pnlProfessorUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfessorUserControl.Location = new System.Drawing.Point(0, 0);
            this.pnlProfessorUserControl.Name = "pnlProfessorUserControl";
            this.pnlProfessorUserControl.Size = new System.Drawing.Size(272, 100);
            this.pnlProfessorUserControl.TabIndex = 0;
            // 
            // ucProfessor
            // 
            this.ucProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProfessor.Location = new System.Drawing.Point(0, 0);
            this.ucProfessor.Name = "ucProfessor";
            this.ucProfessor.Size = new System.Drawing.Size(272, 100);
            this.ucProfessor.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 100);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(272, 25);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(75, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProfessorDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 126);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlProfessorUserControl);
            this.Name = "ProfessorDelete";
            this.Text = "ProfessorDelete";
            this.pnlProfessorUserControl.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfessorUserControl;
        private UserControls.ProfessorUserControl ucProfessor;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}