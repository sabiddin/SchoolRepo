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
    public partial class ProfessorUpdate : Form
    {
        private IProfessorViewModel _professorViewModel;
        private Professor professorToBeUpdated;
        private List<Department> _departments = new List<Department>();
        public bool Success { get; set; }
        public ProfessorUpdate(IProfessorViewModel professorViewModel,Professor professor)
        {
            InitializeComponent();
            _professorViewModel = professorViewModel;
            professorToBeUpdated = professor;
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
            ucProfessor.txtID.Text = professorToBeUpdated.ID.ToString();
            ucProfessor.txtProfFirstName.Text = professorToBeUpdated.ProfFirstName;
            ucProfessor.txtProfMiddleName.Text = professorToBeUpdated.ProfMiddleName;
            ucProfessor.txtProfLastName.Text = professorToBeUpdated.ProfLastName;
            ucProfessor.cboDepartment.SelectedValue = professorToBeUpdated.Department.DepartmentCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            professorToBeUpdated.ProfFirstName = ucProfessor.txtProfFirstName.Text;
            professorToBeUpdated.ProfMiddleName = ucProfessor.txtProfMiddleName.Text;
            professorToBeUpdated.ProfLastName = ucProfessor.txtProfLastName.Text;
            professorToBeUpdated.Department.ID = Convert.ToInt32(ucProfessor.cboDepartment.SelectedIndex);
            Success = _professorViewModel.UpdateProfessor(professorToBeUpdated);
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
