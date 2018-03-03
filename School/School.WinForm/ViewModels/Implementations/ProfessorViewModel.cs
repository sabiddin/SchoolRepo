using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Business.Interfaces;
using School.Entities;
using School.WinForm.ViewModels.Interfaces;

namespace School.WinForm.ViewModels.Implementations
{
    public class ProfessorViewModel : IProfessorViewModel
    {
        private IProfessorBusinesss _professorBusinesss;
        public ProfessorViewModel(IProfessorBusinesss professorBusinesss)
        {
            _professorBusinesss = professorBusinesss;
        }
        public List<Professor> GetProfessors()
        {
            return _professorBusinesss.GetProfessors();
        }

        public List<Professor> GetProfessorsByLastName(string LastName)
        {
            return _professorBusinesss.GetProfessorsByLastName(LastName);
        }
    }
}
