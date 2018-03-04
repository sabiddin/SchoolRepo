using School.Entities;
using School.WinForm.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.WinForm.Views.StudentViews
{
    public partial class StudentDelete : Form
    {
        private IStudentViewModel _studentViewModel;
        private Student _student;
        public bool Success { get; set; }

        public StudentDelete()
        {
            InitializeComponent();
        }
        public StudentDelete(IStudentViewModel studentViewModel, Student student)
        {
            _studentViewModel = studentViewModel;
            _student = student;
            InitializeComponent();
            ucStudent.txtID.Text = _student.ID.ToString();
            ucStudent.txtStudFirstName.Text = _student.StudFirstName;
            ucStudent.txtStudFirstName.ReadOnly = true;
            ucStudent.txtStudLastName.Text = _student.StudLastName;
            ucStudent.txtStudLastName.ReadOnly = true;
            ucStudent.txtStudMiddleName.Text = _student.StudMiddleName;
            ucStudent.txtStudMiddleName.ReadOnly = true;
            ucStudent.cboDepartment.Text = _student.Department.ToString();
            ucStudent.cboDepartment.Enabled = false;
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Success = _studentViewModel.DeleteStudent(Convert.ToInt32(ucStudent.txtID.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
