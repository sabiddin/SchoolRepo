using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Entities;
using School.WinForm.ViewModels.Interfaces;

namespace School.WinForm.Views.ProfessorViews
{
    public partial class ProfessorDelete : Form
    {
        private IProfessorViewModel _professorViewModel;
        private Professor professorToBeDeleted;
        private List<Department> _departments = new List<Department>();
        public bool Success { get; set; }
        public ProfessorDelete(IProfessorViewModel professorViewModel, Professor professor)
        {
            InitializeComponent();
            _professorViewModel = professorViewModel;
            professorToBeDeleted = professor;
            InitializeProfessorUserControl();
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
        }
        private void InitializeProfessorUserControl()
        {
            ucProfessor.txtID.Text = professorToBeDeleted.ID.ToString();
            ucProfessor.txtProfFirstName.Text = professorToBeDeleted.ProfFirstName;
            ucProfessor.txtProfFirstName.ReadOnly = true;
            ucProfessor.txtProfMiddleName.Text = professorToBeDeleted.ProfMiddleName;
            ucProfessor.txtProfMiddleName.ReadOnly = true;
            ucProfessor.txtProfLastName.Text = professorToBeDeleted.ProfLastName;
            ucProfessor.txtProfLastName.ReadOnly = true;
            ucProfessor.cboDepartment.Text = professorToBeDeleted.Department.ID.ToString();
            ucProfessor.cboDepartment.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Success= _professorViewModel.DeleteProfessor(Convert.ToInt32(ucProfessor.txtID.Text));
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
