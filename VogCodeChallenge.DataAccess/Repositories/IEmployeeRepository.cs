using System.Collections.Generic;
using VogCodeChallenge.DataAccess.Entities;

namespace VogCodeChallenge.DataAccess.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        IEnumerable<Employee> GetEmployeesByDepartmentId(long departmentId);
    }
}
