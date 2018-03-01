using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities;
using School.Business.Interfaces;
using School.WinForm.ViewModels.Interfaces;

namespace School.WinForm.ViewModels.Implementations
{
    public class DepartmentViewModel:IDepartmentViewModel
    {
        private IDepartmentBusiness _departmentBusiness;
        public DepartmentViewModel(IDepartmentBusiness departmentBusiness)
        {
            _departmentBusiness = departmentBusiness;
        }
        public List<Department> GetDepartments() {
            return _departmentBusiness.GetDepartments();
        }
        public List<Department> GetDepartmentsByCode(string Code) {
            return _departmentBusiness.GetDepartmentsByCode(Code);
        }
    }
}
