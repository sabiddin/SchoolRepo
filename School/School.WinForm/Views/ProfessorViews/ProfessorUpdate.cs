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
        public bool Success { get; set; }
        public ProfessorUpdate(IProfessorViewModel professorViewModel,Professor professor)
        {
            _professorViewModel = professorViewModel;
            InitializeComponent();
        }
    }
}
