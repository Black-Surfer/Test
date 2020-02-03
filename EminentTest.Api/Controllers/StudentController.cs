using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EminentTest.Abstraction.Service.Data;
using EminentTest.DB.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EminentTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentDataService _studentService;
        public StudentController(IStudentDataService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _studentService.GetStudents();
            if (result.Count() > 0)
                return Ok(result);
            return NotFound("No Student ");
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _studentService.GetStudent(id);
            if (result != null)
                return Ok(result);
            return NotFound();
        }

        // POST: api/Student
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student body)
        {
            if (body == null)
            {
                return BadRequest("Student is null.");
            }

            await _studentService.AddStudent(body);
            return CreatedAtRoute(
                  "Get",
                  new { Id = body.Id },
                  body);
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Student body)
        {
            if (body == null)
            {
                return BadRequest("Student is null.");
            }
            await _studentService.UpdateStudent(body);
            return NoContent();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _studentService.DeleteStudent(id);
            return NoContent();
        }
    }
}
