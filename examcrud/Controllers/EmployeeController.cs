using examcrud.Data;
using examcrud.Models.Dtos;
using examcrud.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace examcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostEmployee([FromBody] EmployeeDto employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Signup failed. Please provide valid data.",
                    errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                });
            }



            var keywords = new List<string> { "the", "badboy", "baby", "hack", "fake" };

            foreach (var keyword in keywords)
            {
                if (employee.FirstName.ToLower() == keyword)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Please don't use reserved words in the first name."
                    });
                }
            }




            // Logic to save employee data here

            return Ok(new
            {
                success = true,
                message = "Employee created successfully."
            });
        }

    }
}
