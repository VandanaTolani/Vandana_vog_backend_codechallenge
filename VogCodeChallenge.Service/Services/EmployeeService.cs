using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.DataAccess.Repositories;
using VogCodeChallenge.Service.Models;

namespace VogCodeChallenge.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return employees.Select(x => _mapper.Map<Employee>(x));
        }

        public IEnumerable<Employee> GetByDepartmentId(long departmentId)
        {
            var employees = _employeeRepository.GetEmployeesByDepartmentId(departmentId);
            return employees.Select(x => _mapper.Map<Employee>(x));
        }

        public IList<Employee> ListAll()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return employees.Select(x => _mapper.Map<Employee>(x)).ToList();
        }
    }
}
