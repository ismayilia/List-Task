using Collections_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_List.Services.Interfaces
{    
    internal interface IEmployeeService
    {
        // Employee-leri geri qaytaran method

        List<Employee> GetAll();

        //Salary araliginda olanlari cixartmaq ucun
        List<Employee> FilterBySalary(decimal firstSalary, decimal secondSalary, List<Employee> employees);

    }
}
