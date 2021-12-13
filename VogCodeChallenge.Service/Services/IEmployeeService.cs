using System.Collections.Generic;
using VogCodeChallenge.Service.Models;

namespace VogCodeChallenge.Service.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IEnumerable<Employee> GetByDepartmentId(long departmentId);
    }
}
