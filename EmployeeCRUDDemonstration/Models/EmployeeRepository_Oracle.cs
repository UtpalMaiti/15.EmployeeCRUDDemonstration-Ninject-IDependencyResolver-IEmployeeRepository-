using EmployeeCRUDDemonstration.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDDemonstration.Models
{
    public class EmployeeRepository_Oracle : IEmployeeRepository
    {
        ITest test;
        public EmployeeRepository_Oracle(ITest t)
        {
            test = t;
        }
        public List<Employee> GetAllEmployees()
        {
            return test.TestMethod();
        }

        public bool Create(Employee emp)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        

        public Employee GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}