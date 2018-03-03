using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Business.Implementations;
using School.Business.Interfaces;
using School.DataAccess.Implementations;
using School.DataAccess.Interfaces;
using School.WinForm.ViewModels.Implementations;
using School.WinForm.ViewModels.Interfaces;
using School.WinForm.Views.CourseViews;
using School.WinForm.Views;

namespace School.WinForm
{
    public class SchoolRegistry : Registry
    {
        public SchoolRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();                
                scan.WithDefaultConventions();               
            });

            For<ICourseViewModel>().Use<CourseViewModel>();
            For<IDepartmentViewModel>().Use<DepartmentViewModel>();
            For<IProfessorViewModel>().Use<ProfessorViewModel>();
            For<IStudentViewModel>().Use<StudentViewModel>();
            //Business
            For<ICourseBusiness>().Use<CourseBusiness>();
            For<IDepartmentBusiness>().Use<DepartmentBusiness>();
            For<IStudentBusiness>().Use<StudentBusiness>();
            For<IProfessorBusinesss>().Use<ProfessorBusiness>();
            //Data Acccess
            For<ICourseDataAccess>().Use<CourseDataAccess>();           
            For<IDepartmentDataAccess>().Use<DepartmentDataAccess>();
            For<IProfessorDataAccess>().Use<ProfessorDataAccess>();
            For<IStudentDataAccess>().Use<StudentDataAccess>();


        }
    }
}
