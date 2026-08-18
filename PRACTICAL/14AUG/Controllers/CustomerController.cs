using _14AUG.Model;
using _14AUG.Repository;
using _14AUG.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _14AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult GetAll()
        {
            var customers = service.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Customer")]
        public IActionResult GetCustomer(int id)
        {
           var cust= service.GetCustomerById(id);
            if (cust == null)
                return NotFound("No customer");
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddCustomer(Customer customer)
        {
            service.AddCustomer(customer);
            return Ok();

        }
    }
}
