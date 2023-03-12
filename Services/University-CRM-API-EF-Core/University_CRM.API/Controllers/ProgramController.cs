using Microsoft.AspNetCore.Mvc;
using University_CRM.Application.Features.Programs.Commands;
using University_CRM.Application.Features.Programs.Queries.GetProgram;

namespace University_CRM.API.Controllers
{
    public class ProgramController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> AddProgramCommand([FromBody] AddProgramCommand command)
        {
            var programId = await Mediator.Send(command);
            return Created(nameof(AddProgramCommand),2);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProgram(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            return Ok(await Mediator.Send(new GetProgramQuery { Id = id.Value }));
        }
        
    }
}
