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

namespace School.WinForm.Views.ProfessorViews
{
    public partial class ProfessorCreate : Form
    {
        public bool Success { get; set; }
        private IProfessorViewModel _professorViewModel;
        private List<Department> _departments = new List<Department>();
        public ProfessorCreate()
        {
            InitializeComponent();
        }
        public ProfessorCreate(IProfessorViewModel professorViewModel)
        {
            _professorViewModel = professorViewModel;
            InitializeComponent();
            _departments = _professorViewModel.GetDepartments();
            _departments.Insert(0, new Department()
            {
                ID = 0,
                DepartmentCode = "",
                DepartmentDescription = "Please Select"
            });

            ucProfessor.cboDepartment.DataSource = _departments;
            ucProfessor.cboDepartment.DisplayMember = "DepartmentDescription";
            ucProfessor.cboDepartment.ValueMember = "DepartmentCode";

            ucProfessor.lblID.Hide();
            ucProfessor.txtID.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Success = Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Save()
        {
            Professor professor = new Professor();
            professor.ProfFirstName = ucProfessor.txtProfFirstName.Text;
            professor.ProfMiddleName = ucProfessor.txtProfMiddleName.Text;
            professor.ProfLastName = ucProfessor.txtProfLastName.Text;
            if (ucProfessor.cboDepartment.SelectedIndex > 0)
            {
                //Using Lamda expression.                
                Department dept = ucProfessor.cboDepartment.SelectedItem as Department;
                professor.Department = dept;
            }
            return _professorViewModel.AddProfessor(professor);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
