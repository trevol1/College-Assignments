using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Registracio.WebApplication.Models;

namespace Registracio.WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase

    {
        private readonly RegistracioWebApplicationContext _context;

        public EmployeesController(RegistracioWebApplicationContext context)
        {
            _context = context;
        }
        // GET: api/Employees
        [HttpGet]
        

        // GET: api/Employees
        public IEnumerable<Employees> GetEmployees()
        {
            return _context.Employees;
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employees
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
