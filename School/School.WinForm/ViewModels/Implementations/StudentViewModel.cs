using School.Business.Interfaces;
using School.Entities;
using School.WinForm.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.WinForm.ViewModels.Implementations
{
    public class StudentViewModel:  IStudentViewModel
    {
        private IStudentBusiness _studentBusiness; 
        public StudentViewModel(IStudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;
        }

        public List<Student> GetStudents()
        {
            return _studentBusiness.GetStudents();
        }

        public List<Student> GetStudentsByLastName(string LastName)
        {
            return _studentBusiness.GetStudentsByLastName(LastName);
        }
    }
}
