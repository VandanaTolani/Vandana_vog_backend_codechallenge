using System.Collections.Generic;

namespace VogCodeChallenge.DataAccess.Entities
{
    public class Department
    {
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
