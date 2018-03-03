﻿using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.WinForm.ViewModels.Interfaces
{
    public interface IStudentViewModel
    {
        List<Student> GetStudents();
        List<Student> GetStudentsByLastName(string LastName);
    }
}
