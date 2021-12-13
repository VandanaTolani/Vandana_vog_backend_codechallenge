using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using VogCodeChallenge.Service.Models;
using VogCodeChallenge.Service.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeeService _employeeService;
        public EmployeesController(ILogger<EmployeesController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpGet("department/{departmentId:long}")]
        [MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByDepartment(long departmentId)
        {
            var employees = _employeeService.GetByDepartmentId(departmentId);
            return Ok(employees);
        }
    }
}