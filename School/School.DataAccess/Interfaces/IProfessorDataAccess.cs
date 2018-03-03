﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace School.DataAccess.Interfaces
{
    public interface IProfessorDataAccess
    {
        DataTable GetProfessors();
        DataTable GetProfessorByLastName(string LastName);
    }
}
