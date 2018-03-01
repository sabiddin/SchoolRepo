using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities;
using School.Business.Interfaces;

namespace School.WinForm.ViewModels.Interfaces
{
    public interface IDepartmentViewModel
    {
        List<Department> GetDepartments();
        List<Department> GetDepartmentsByCode(string Code);
    }
}
