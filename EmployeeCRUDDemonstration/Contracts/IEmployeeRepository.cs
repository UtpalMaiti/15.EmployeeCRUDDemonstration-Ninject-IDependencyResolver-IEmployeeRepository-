using EmployeeCRUDDemonstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUDDemonstration.Contracts
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int Id);

        bool Create(Employee emp);

        bool Update(Employee emp);

        bool Delete(int Id);
    }
}
