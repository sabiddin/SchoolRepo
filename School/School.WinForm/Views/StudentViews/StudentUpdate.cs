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
    public partial class StudentUpdate : Form
    {
        public bool Success { get; set; }
        private IStudentViewModel _studentViewModel;
        private Student _studentToBeUpdated;
        private List<Department> _departments = new List<Department>();


        public StudentUpdate()
        {
            InitializeComponent();
        }
        public StudentUpdate(IStudentViewModel studentViewModel, Student student)
        {
            _studentViewModel = studentViewModel;
            _studentToBeUpdated = student;
            InitializeComponent();            
            _departments = _studentViewModel.GetDepartments();
            _departments.Insert(0, new Department()
            {
                ID = 0,
                DepartmentCode = "",
                DepartmentDescription = "Please Select"
            });
            ucStudent.cboDepartment.DataSource = _departments;
            ucStudent.cboDepartment.DisplayMember = "DepartmentDescription";
            ucStudent.cboDepartment.ValueMember = "DepartmentCode";
            InitializeStudentUserControl();

        }

        private void InitializeStudentUserControl()
        {
            ucStudent.txtID.Text = _studentToBeUpdated.ID.ToString();
            ucStudent.txtStudFirstName.Text = _studentToBeUpdated.StudFirstName;
            ucStudent.txtStudLastName.Text = _studentToBeUpdated.StudLastName;
            ucStudent.txtStudMiddleName.Text = _studentToBeUpdated.StudMiddleName;
            ucStudent.cboDepartment.SelectedValue = _studentToBeUpdated.Department.DepartmentCode;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _studentToBeUpdated.StudFirstName = ucStudent.txtStudFirstName.Text;
            _studentToBeUpdated.StudLastName = ucStudent.txtStudLastName.Text;

            _studentToBeUpdated.StudMiddleName = ucStudent.txtStudMiddleName.Text;
            _studentToBeUpdated.Department.ID = Convert.ToInt32(ucStudent.cboDepartment.SelectedIndex);
            Success = _studentViewModel.UpdateStudent(_studentToBeUpdated);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
