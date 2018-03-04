using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.WinForm.ViewModels.Interfaces
{
    public interface IProfessorViewModel
    {
        List<Professor> GetProfessors();
        List<Professor> GetProfessorsByLastName(string LastName);
        List<Department> GetDepartments();
        bool AddProfessor(Professor professor);
        bool UpdateProfessor(Professor professor);
        bool DeleteProfessor(int ID);
    }
}
