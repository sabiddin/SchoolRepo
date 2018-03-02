using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;
using StructureMap.Attributes;
using School.WinForm.Views;
using School.WinForm.ViewModels.Interfaces;

namespace School.WinForm
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            var container = Container.For<SchoolRegistry>();
            var courseViewModel = container.GetInstance<ICourseViewModel>();
            var departmentViewModel = container.GetInstance<IDepartmentViewModel>();
            Application.Run(new Index(departmentViewModel,courseViewModel));
        }       
    }
   
}
