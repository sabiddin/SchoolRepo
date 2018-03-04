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
        private IDepartmentBusiness _departmentBusiness;
        public ProfessorViewModel(IProfessorBusinesss professorBusinesss, IDepartmentBusiness departmentBusiness)
        {
            _professorBusinesss = professorBusinesss;
            _departmentBusiness = departmentBusiness;
        }
        public List<Professor> GetProfessors()
        {
            return _professorBusinesss.GetProfessors();
        }

        public List<Professor> GetProfessorsByLastName(string LastName)
        {
            return _professorBusinesss.GetProfessorsByLastName(LastName);
        }
        public bool AddProfessor(Professor professor)
        {
            return _professorBusinesss.AddProfessor(professor);
        }
        public List<Department> GetDepartments()
        {
            return _departmentBusiness.GetDepartments();
        }
        public bool UpdateProfessor(Professor professor)
        {
            return _professorBusinesss.UpdateProfessor(professor);
        }
        public bool DeleteProfessor(int ID)
        {
            return _professorBusinesss.DeleteProfessor(ID);
        }
    }
}
