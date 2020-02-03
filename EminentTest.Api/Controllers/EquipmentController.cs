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
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentDataService _equipmentService;
        public EquipmentController(IEquipmentDataService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        // GET: api/Equipment
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _equipmentService.GetEquipments();
            if (result.Count() > 0)
                return Ok(result);
            return NotFound("No Equipment");
        }

        //// SEARCH: api/Equipment
        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search([FromQuery] string name, [FromQuery] int status, [FromQuery] int type)
        {
            var result = await _equipmentService.SearchEquipment(name, status, type);
            if (result.Count() > 0)
                return Ok(result);
            return NotFound("No Equipment Found");
        }

        // GET: api/Equipment/5
        [HttpGet("{id}", Name = "GetEquipment")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _equipmentService.GetEquipment(id);
            if (result != null)
                return Ok(result);
            return NotFound("No Equipment Found");
        }

        // POST: api/Equipment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Equipment body)
        {
            if (body == null)
            {
                return BadRequest("Equipment is null.");
            }

            await _equipmentService.AddEquipment(body);
            return CreatedAtRoute(
                  "Get",
                  new { Id = body.Id },
                  body);
        }

        // PUT: api/Equipment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Equipment body)
        {
            if (body == null)
            {
                return BadRequest("Equipment is null.");
            }
            await _equipmentService.UpdateEquipment(body);
            return NoContent();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _equipmentService.DeleteEquipment(id);
            return NoContent();
        }
    }
}
