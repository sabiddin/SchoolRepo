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
        public Index(IDepartmentViewModel departmentViewModel,ICourseViewModel courseViewModel)
        {
            InitializeComponent();
            _departmentViewModel = departmentViewModel;
            _courseViewModel = courseViewModel;
            //1. Instantiate the Department user control.
            DepartmentSearchUserControl departmentSearchUserControl = new DepartmentSearchUserControl(_departmentViewModel);
            //2. Add it to Tab page with name tabDepartments
            tabIndex.TabPages["tabDepartments"].Controls.Add(departmentSearchUserControl);
            //3. Dock the department user control as fill.
            departmentSearchUserControl.Dock = DockStyle.Fill;
            //4. Instantiate user control for courses.
            CourseSearchUserControl courseSearchUserControl = new CourseSearchUserControl(_courseViewModel);
            //5. Add it to tab page tabCorses.
            tabIndex.TabPages["tabCourses"].Controls.Add(courseSearchUserControl);
            //6. Dock user control for courses as fill.
            courseSearchUserControl.Dock = DockStyle.Fill;

        }
       
    }
}
