using _27JUL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _27JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=101, Name= "Ritika ", LastNmae="Shimbre", Dept="IT", PhoneNum=7558508832,Profile = "Software Developer",Location = "Pune"},
            new Employee(){Id=102, Name= "Payal ", LastNmae="Singh", Dept="IT", PhoneNum=8758508832, Profile = "Web Develope",   Location = "Mumbai"},
            new Employee(){Id=103, Name= "Gauri ", LastNmae="Kumar", Dept="IT", PhoneNum=9875632532,Profile = "Database Administrator", Location = "Nagpur"},
            new Employee(){Id=104, Name= "Shivani ", LastNmae="Bute", Dept="IT", PhoneNum=725756748832, Profile = "Software Tester", Location = "Nashik"}
        };

        //get all employee list
        [HttpGet]

        public IActionResult getEmployee()
        {
            return Ok(employees);  //ok-200

        }

        [HttpGet("{id}")]

        public IActionResult getEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpPost]

        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        //edit employee record

        [HttpPut("{id}")]

        public IActionResult UpdateEmployee(int  id, Employee employee)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id==id);
            if(employee1 == null)
            {
                return NotFound();
            }
            employee1.LastNmae= employee.LastNmae;
            return Ok(employee1);
        }

        [HttpGet("Dept/{dept}")] 
        public IActionResult GetEmployeeByDept(string dept) 
        { 
            var result = employees.Where(s => s.Dept.Equals(dept, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any())
            {
                return NotFound("Not employee found under this dept");
            }
            return Ok(result); }

        [HttpGet("Profile/{profile}")]

        public IActionResult GetEmployeeByProfile(string profile)
        {
            var result = employees.Where(s => s.Profile.Equals(profile, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any())
            {
                return NotFound("Not employee found under this required profile");
            }
            return Ok(result);
        }

        [HttpGet("Location/{location}")]

        public IActionResult GetEmployeeByLocation(string location)

        {
            var result = employees.Where(s => s.Location.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any())
            {
                return NotFound("Not employee found under this required location");
            }
            return Ok(result);

        }
    }
}
