﻿using challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(String id);
        Employee GetById(String id, bool includeDirectReports);
        Compensation GetCompensationByEmployeeId(String id);
        Compensation Create(Compensation compensation);
        Employee Create(Employee employee);
        Employee Replace(Employee originalEmployee, Employee newEmployee);


    }
}