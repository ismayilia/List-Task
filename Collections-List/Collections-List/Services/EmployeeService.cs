using Collections_List.Models;
using Collections_List.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_List.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public List<Employee> FilterBySalary(decimal firstSalary, decimal secondSalary, List<Employee> employees)
        {
            return employees.FindAll(m => m.Salary > firstSalary && m.Salary < secondSalary); 
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new();

            list.Add(new Employee {Id = 1, Fullname = "Ismayil Efendizade", Age = 29, Salary = 2000});
            list.Add(new Employee { Id = 2, Fullname = "Samir Qehramanov", Age = 25, Salary = 2500 });
            list.Add(new Employee { Id = 3, Fullname = "Fidan Bashirova", Age = 22, Salary = 3000 });
            list.Add(new Employee { Id = 4, Fullname = "Kubra Memmedova", Age = 25, Salary = 2400 });
            list.Add(new Employee { Id = 5, Fullname = "Pervin Mirzeyev", Age = 30, Salary = 4500 });


            return list;
        }
    }
}
