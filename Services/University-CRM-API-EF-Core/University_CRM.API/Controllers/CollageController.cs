﻿using Microsoft.AspNetCore.Mvc;
using University_CRM.Application.Features.Collages.Commands;
using University_CRM.Application.Features.Collages.Queries;

namespace University_CRM.API.Controllers
{
    public class CollageController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> AddCollage(AddCollageCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpPost("Collocation")]
        public async Task<IActionResult> AddCollageCollocation(AddCollageCollocationCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCollageQuery query)
            => Ok(await Mediator.Send(query));
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCollage([FromRoute] int? id)
        {
            if (id is null)
                return BadRequest();
            var collage = await Mediator.Send(new GetCollageQuery() { Id = id.Value });
            return Ok(collage);
        }
        [HttpPut()]
        public async Task<IActionResult> FullUpdateCollage([FromBody] FullUpdateCollageCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpPut("Collocation")]
        public async Task<IActionResult> FullUpdateCollageCollocation([FromBody] FullUpdateCollageCollocationCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> ParialUpdateCollage(int? id, ParialUpdateCollageCommand command)
        {
            if (id is null)
                return BadRequest();
            command.Id = id.Value;
            await Mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollage(int? id)
        {
            if (id is null)
                return BadRequest();
            await Mediator.Send(new DeleteCollageCommand { Id = id.Value});
            return NoContent();
        }
        [HttpDelete("Collocation")]
        public async Task<IActionResult> DeleteCollageCollocation([FromQuery] DeleteCollageCollocationCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
