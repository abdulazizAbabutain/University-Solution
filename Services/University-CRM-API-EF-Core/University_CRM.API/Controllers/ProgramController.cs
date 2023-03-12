using Microsoft.AspNetCore.Mvc;
using University_CRM.Application.Features.Programs.Commands;

namespace University_CRM.API.Controllers
{
    public class ProgramController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> AddProgramCommand([FromBody] AddProgramCommand command)
        {
            var program = await Mediator.Send(command);
            return Ok();
        }
        
    }
}
