using _29JUL.Model;
using _29JUL.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29JUL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmployees());
        }

        [HttpGet("{deptid:int}")]
        public IActionResult GetById(int deptid)
        {
            var employee = _service.getEmployee(deptid);

            if (employee == null)
                return NotFound("Employee with id not found");

            return Ok(employee);
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var employee = _service.getEmployeeName(name);

            if (employee == null)
                return NotFound("Employee with name not found");

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var res = _service.addEmployee(employee);
            return Ok(res);
        }

    }
}
