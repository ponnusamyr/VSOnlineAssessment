﻿using HCA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Service.IHCAService
{
    public interface IHCAMaster
    {
       public List<EmployeeDto> GetAllEmployee();
    }
}
