using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Entities;
using School.WinForm.ViewModels.Interfaces;
using School.WinForm.Views;
using School.WinForm.Views.CourseViews;

namespace School.WinForm.Views.UserControls
{
    public partial class DepartmentSearchUserControl : UserControl
    {
        private IDepartmentViewModel _departmentViewModel;
        public DepartmentSearchUserControl(IDepartmentViewModel departmentViewModel)
        {
            InitializeComponent();
            _departmentViewModel = departmentViewModel;
            LoadData();
        }
        private void LoadData()
        {
            string searchTerm = string.IsNullOrEmpty(txtDepartmentName.Text) ? "" : txtDepartmentName.Text;
            dgvDepartments.Rows.Clear();
            foreach (Department department in _departmentViewModel.GetDepartmentsByCode(searchTerm))
            {
                dgvDepartments.Rows.Add(department.ID, department.DepartmentCode,
                    department.DepartmentDescription, "Edit", "Delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
