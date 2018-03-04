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
        private IDepartmentBusiness _departmentBusiness;
        private IStudentBusiness _studentBusiness; 
        public StudentViewModel(IStudentBusiness studentBusiness, IDepartmentBusiness departmentBusiness)
        {
            _studentBusiness = studentBusiness;
            _departmentBusiness = departmentBusiness;
        }

        public List<Student> GetStudents()
        {
            return _studentBusiness.GetStudents();
        }

        public List<Student> GetStudentsByLastName(string LastName)
        {
            return _studentBusiness.GetStudentsByLastName(LastName);
        }
        public List<Department> GetDepartments()
        {
            return  _departmentBusiness.GetDepartments();
    }
        public bool AddStudent(Student student)
        {
            return _studentBusiness.AddStudent(student);
        }
        public bool UpdateStudent(Student student)
        {
            return _studentBusiness.UpdateStudent(student);
        }
        public bool DeleteStudent(int ID)
        {
            return _studentBusiness.DeleteStudent(ID);
        }
    }
}
