using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace School.DataAccess.Interfaces
{
    public interface IStudentDataAccess
    {
        DataTable GetSudents();
        DataTable GetStudentByLastName(string LastName);
    }
}
