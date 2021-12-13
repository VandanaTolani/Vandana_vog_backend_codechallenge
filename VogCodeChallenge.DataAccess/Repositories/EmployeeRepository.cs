using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.DataAccess.Entities;

namespace VogCodeChallenge.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEnumerable<Employee> _employees = new List<Employee>()
        {
            new Employee()
            {
                FirstName = "John",
                LastName = "Smith",
                DepartmentId = 1,
                JobTitle =  "Sr. Software Engineer",
                MailingAddress  = new Address()
                {
                    StreetAddress = "12 Menlo park, California"
                }
            },
            new Employee()
            {
                FirstName = "Bob",
                LastName = "Doe",
                DepartmentId = 2,
                JobTitle =  "QA Analyst",
                MailingAddress  = new Address()
                {
                    StreetAddress = "22 Hacker way, Seattle"
                }
            },
            new Employee()
            {
                FirstName = "Justin",
                LastName = "Stanley",
                DepartmentId = 1,
                JobTitle =  "Product Owner",
                MailingAddress  = new Address()
                {
                    StreetAddress = "1 Bloor st, Toronto"
                }
            },
            new Employee()
            {
                FirstName = "Mike",
                LastName = "Tim",
                DepartmentId = 3,
                JobTitle =  "Scrum Master",
                MailingAddress  = new Address()
                {
                    StreetAddress = "87 Blue Jay way, Etobicoke"
                }
            }

        };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public IEnumerable<Employee> GetEmployeesByDepartmentId(long departmentId)
        {
            return _employees.Where(x => x.DepartmentId == departmentId);
        }
    }
}
