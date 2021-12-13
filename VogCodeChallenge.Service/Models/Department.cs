using System.Collections;
using System.Collections.Generic;

namespace VogCodeChallenge.Service.Models
{
    public class Department
    {
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Employee>  Employees { get; set; }
    }
}
