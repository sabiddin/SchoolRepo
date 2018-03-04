using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.WinForm.ViewModels.Interfaces;
using School.Entities;
using School.WinForm.Views.ProfessorViews;

namespace School.WinForm.Views.UserControls
{
    public partial class ProfessorSearchUserControl : UserControl
    {
        private IProfessorViewModel _professorViewModel;
        private List<Professor> professors = new List<Professor>();
        public ProfessorSearchUserControl(IProfessorViewModel professorViewModel)
        {
            InitializeComponent();
            _professorViewModel = professorViewModel;
            LoadData();
        }
        private void LoadData()
        {
            string searchTerm = string.IsNullOrEmpty(txtProfLastName.Text) ? "" : txtProfLastName.Text;
            dgvProfessors.Rows.Clear();
            professors = _professorViewModel.GetProfessorsByLastName(searchTerm);
            foreach (Professor professor in professors)
            {
                dgvProfessors.Rows.Add(professor.ID, professor.ProfFirstName,
                    professor.ProfMiddleName, professor.ProfLastName,
                    professor.Department.DepartmentDescription, "Edit", "Delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProfessorCreate studentCreate = new ProfessorCreate(_professorViewModel);
            studentCreate.ShowDialog();
            if (studentCreate.Success)
                LoadData();
        }

        private void dgvProfessors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvProfessors.Rows[rowIndex];
            int professorID = Convert.ToInt32(row.Cells["colID"].Value.ToString());
            Professor professor = professors.FirstOrDefault(s => s.ID == professorID);
            switch (columnIndex)
            {
                case 5:
                    ProfessorUpdate updateView = new ProfessorUpdate(_professorViewModel, professor);
                    updateView.ShowDialog();
                    if (updateView.Success)
                        LoadData();
                    break;
                case 6:
                    ProfessorDelete deleteview = new ProfessorDelete(_professorViewModel, professor);
                    deleteview.ShowDialog();
                    if (deleteview.Success)
                        LoadData();
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtProfLastName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
