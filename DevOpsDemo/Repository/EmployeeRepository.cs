using DevOpsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeViewModel> GetEmployees()
        {
            var Employees = new List<EmployeeViewModel> {
                new EmployeeViewModel(){ EmployeeId =101, Project = "HCLPaaSCOE", Designation ="Specialist", Name="Vikas Kumar Sharma"},
                new EmployeeViewModel(){ EmployeeId =102, Project = "HCLPaaSCOE", Designation ="Specialist", Name="Abhinav Sharma"},
                new EmployeeViewModel(){ EmployeeId =103, Project = "HCLPaaSCOE", Designation ="Specialist", Name="Geshu Pandey"},
            };

            return Employees;
        }
    }
}
