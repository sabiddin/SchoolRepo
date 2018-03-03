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
    public partial class StudentUpdate : Form
    {
        public bool Success { get; set; }
        public StudentUpdate(IStudentViewModel studentViewModel, Student student)
        {
            InitializeComponent();
        }
    }
}
