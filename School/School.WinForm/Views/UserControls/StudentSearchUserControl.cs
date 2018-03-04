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
using School.WinForm.Views.StudentViews;

namespace School.WinForm.Views.UserControls
{
    public partial class StudentSearchUserControl : UserControl
    {
        private IStudentViewModel _studentViewModel;
        private List<Student> students = new List<Student>();
        public StudentSearchUserControl(IStudentViewModel studentViewModel)
        {
            InitializeComponent();
            _studentViewModel = studentViewModel;
            LoadData();
        }
        private void LoadData()
        {
            string searchTerm = string.IsNullOrEmpty(txtStudLastName.Text) ? "" : txtStudLastName.Text;
            dgvStudents.Rows.Clear();
            students = _studentViewModel.GetStudentsByLastName(searchTerm);
            foreach (Student student in students)
            {
                dgvStudents.Rows.Add(student.ID, student.StudFirstName,
                    student.StudMiddleName, student.StudLastName,
                    student.Department.DepartmentDescription, "Edit", "Delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentCreate studentCreate = new StudentCreate(_studentViewModel);
            studentCreate.ShowDialog();
            if (studentCreate.Success)
                LoadData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvStudents.Rows[rowIndex];
            int studentID = Convert.ToInt32(row.Cells["colID"].Value.ToString());
            Student student = students.FirstOrDefault(s => s.ID == studentID);
            switch (columnIndex)
            {
                case 5:
                    StudentUpdate updateView = new StudentUpdate(_studentViewModel, student);
                    updateView.ShowDialog();
                    if (updateView.Success)
                        LoadData();
                    break;
                case 6:
                    StudentDelete deleteView = new StudentDelete(_studentViewModel, student);
                    deleteView.ShowDialog();
                    if (deleteView.Success)
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

        private void txtStudLastName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
