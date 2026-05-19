using Application.Interfaces;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _service;

        public ClassController(IClassService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> Get()
        {
            var classes = await _service.GetAll();

            return Ok(classes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetById(Guid id)
        {
            var gymClass = await _service.GetById(id);

            if (gymClass == null)
                return NotFound();

            return Ok(gymClass);
        }

        [HttpPost]
        public async Task<ActionResult<Class>> Post([FromBody] Class gymClass)
        {
            if (gymClass == null)
                return BadRequest();

            if (string.IsNullOrEmpty(gymClass.Name))
                return BadRequest("Name is required.");

            var created = await _service.Create(gymClass);

            return CreatedAtAction(nameof(GetById),
                new { id = created.Id },
                created);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(Guid id, Class gymClass)
        {
            var updated = await _service.Update(id, gymClass);

            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _service.Delete(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}