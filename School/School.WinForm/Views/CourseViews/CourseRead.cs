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

namespace School.WinForm.Views.CourseViews
{
    public partial class CourseRead : Form
    {
        private ICourseViewModel _courseViewModel;
               
        public CourseRead()
        {
            InitializeComponent();
            
           // LoadData();
        }
        public CourseRead(ICourseViewModel courseViewModel)
        {
            InitializeComponent();
            _courseViewModel = courseViewModel;
            //LoadData();
            CourseSearchUserControl courseSearchUserControl = new CourseSearchUserControl(_courseViewModel);
            pnlSearchCourses.Controls.Add(courseSearchUserControl);
            courseSearchUserControl.Dock = DockStyle.Fill;
        }
       
       
       
       
    }
}
