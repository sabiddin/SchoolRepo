using School.Business.Interfaces;
using School.DataAccess.Interfaces;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School.Business.Implementations
{
    public class StudentBusiness : IStudentBusiness
    {
        private IStudentDataAccess _studentDataAccess;
        public StudentBusiness(IStudentDataAccess studentDataAccess)
        {
            _studentDataAccess = studentDataAccess;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            DataTable dataTable = _studentDataAccess.GetSudents();
            foreach (DataRow row in dataTable.Rows)
            {
                Student student = new Student() {
                    ID = Convert.ToInt32(row["ID"].ToString()),                    
                    StudFirstName = row["StudFirstName"].ToString(),
                    StudLastName = row["StudLastName"].ToString(),
                    StudMiddleName = row["StudMiddleName"].ToString(),
                };
                student.Department.ID = Convert.ToInt32(row["DepartmentID"].ToString());
                student.Department.DepartmentCode = row["DepartmentCode"].ToString();
                student.Department.DepartmentDescription = row["DepartmentDescription"].ToString();
                students.Add(student);
            }
            return students;
        }

        public List<Student> GetStudentsByLastName(string LastName)
        {
            List<Student> students = new List<Student>();
            DataTable dataTable = _studentDataAccess.GetStudentByLastName(LastName);
            foreach (DataRow row in dataTable.Rows)
            {
                Student student = new Student()
                {
                    ID = Convert.ToInt32(row["ID"].ToString()),                    
                    StudFirstName = row["StudFirstName"].ToString(),
                    StudLastName = row["StudLastName"].ToString(),
                    StudMiddleName = row["StudMiddleName"].ToString()
                };
                student.Department.ID = Convert.ToInt32(row["DepartmentID"].ToString());
                student.Department.DepartmentCode = row["DepartmentCode"].ToString();
                student.Department.DepartmentDescription = row["DepartmentDescription"].ToString();
                students.Add(student);

            }
            return students;
        }
    }
}
