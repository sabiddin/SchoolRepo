
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
    public partial class StudentCreate : Form
    {
        public bool Success { get; set; }
        private IStudentViewModel _studentViewModel;
        
        private List<Department> _departments = new List<Department>();

        public StudentCreate()
        {
            InitializeComponent();
        }
        public StudentCreate(IStudentViewModel studentViewModel)
        {
            _studentViewModel = studentViewModel;
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

            ucStudent.lblID.Hide();
            ucStudent.txtID.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Success = Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Save()
        {
            Student student = new Student();
            student.StudFirstName = ucStudent.txtStudFirstName.Text;
            student.StudLastName = ucStudent.txtStudLastName.Text;
            student.StudMiddleName = ucStudent.txtStudMiddleName.Text;
            
            if (ucStudent.cboDepartment.SelectedIndex > 0)
            {
                //Using Lamda expression.                
                Department dept = ucStudent.cboDepartment.SelectedItem as Department;
                student.Department = dept;
            }
            return _studentViewModel.AddStudent(student);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
