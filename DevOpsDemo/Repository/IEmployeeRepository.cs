using DevOpsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsDemo.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeViewModel> GetEmployees();
    }
}
