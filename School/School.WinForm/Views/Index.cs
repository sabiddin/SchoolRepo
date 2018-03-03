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
using StructureMap.Attributes;
using School.WinForm.Views.UserControls;

namespace School.WinForm.Views
{
    public partial class Index : Form
    {
        private ICourseViewModel _courseViewModel;
        private IDepartmentViewModel _departmentViewModel;
        private IStudentViewModel _studentViewModel;
        private IProfessorViewModel _professorViewModel;
        public Index(IDepartmentViewModel departmentViewModel,ICourseViewModel courseViewModel,IProfessorViewModel professorViewModel, IStudentViewModel studentViewModel)
        {
            _departmentViewModel = departmentViewModel;
            _courseViewModel = courseViewModel;
            _professorViewModel = professorViewModel;
            _studentViewModel = studentViewModel;
            InitializeComponent();           
            //1. Instantiate the Department user control.
            DepartmentSearchUserControl departmentSearchUserControl = new DepartmentSearchUserControl(_departmentViewModel);
            //2. Add it to Tab page with name tabDepartments
            tabIndex.TabPages["pageDepartments"].Controls.Add(departmentSearchUserControl);
            //3. Dock the department user control as fill.
            departmentSearchUserControl.Dock = DockStyle.Fill;
            //4. Instantiate user control for courses.
            CourseSearchUserControl courseSearchUserControl = new CourseSearchUserControl(_courseViewModel);
            //5. Add it to tab page pageCourses.
            tabIndex.TabPages["pageCourses"].Controls.Add(courseSearchUserControl);
            //6. Dock user control for courses as fill.
            courseSearchUserControl.Dock = DockStyle.Fill;
            //7. Instantiate user control for courses.
            ProfessorSearchUserControl professorSearchUserControl = new ProfessorSearchUserControl(_professorViewModel);
            //8. Add it to tab page pageCourses.
            tabIndex.TabPages["pageProfessors"].Controls.Add(professorSearchUserControl);
            //9. Dock user control for courses as fill.
            professorSearchUserControl.Dock = DockStyle.Fill;
            //10. Instantiate user control for students.
            StudentSearchUserControl studentSearchUserControl = new StudentSearchUserControl(_studentViewModel);
            //11. Add it to tab page pageStudents.
            tabIndex.TabPages["pageStudents"].Controls.Add(studentSearchUserControl);
            //12. Dock user control for courses as fill.
            studentSearchUserControl.Dock = DockStyle.Fill;

        }
       
    }
}
