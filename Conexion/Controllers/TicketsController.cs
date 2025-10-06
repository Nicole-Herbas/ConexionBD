using Conexion.Models.dtos;
using Conexion.Services;
using Conexion.Models.dtos;
using Microsoft.AspNetCore.Mvc;

namespace Controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _service;

        public TicketsController(ITicketService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetOne(Guid id)
        {
            var ev = _service.GetById(id);
            return ev == null
                ? NotFound(new { error = "Event not found", status = 404 })
                : Ok(ev);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateTicketDto dto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var ev = _service.Create(dto);
            return CreatedAtAction(nameof(GetOne), new { id = ev.Id }, ev);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var success = _service.Delete(id);
            return success
                ? NoContent()
                : NotFound(new { error = "Ticket not found", status = 404 });
        }
    }
}
