using EmployeeCRUDDemonstration.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDDemonstration.Models
{
    public class TestClass : ITest
    {
        int number;
        public TestClass(int x)
        {
            number = x;
        }

        public string Name { get; set; }

        public List<Employee> TestMethod()
        {
            return new List<Employee>
            {
                new Employee {Id=1,Name="A",Location="Bangalore",Salary=12345 },
                new Employee {Id=2,Name="B",Location="Chennai",Salary=23456 },
                new Employee {Id=3,Name="C",Location="Bangalore",Salary=34567 },
                new Employee {Id=4,Name="D",Location="Chennai",Salary=45678 },
                new Employee {Id=number,Name=Name,Location="Bangalore",Salary=56789 }
            };
        }
    }
}