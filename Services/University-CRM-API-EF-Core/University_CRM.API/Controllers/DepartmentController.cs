using Microsoft.AspNetCore.Mvc;
using University_CRM.Application.Common.Models;
using University_CRM.Application.Features.Departments.Commands;
using University_CRM.Application.Features.Departments.Queries.GetAllDepartments;
using University_CRM.Application.Features.Departments.Queries.GetDepartment;

namespace University_CRM.API.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> AddDepartment(AddDepartmentCommand command)
        {
            await Mediator.Send(command);
            return Ok(); 
        }
        [HttpPost("Collocation")]
        public async Task<IActionResult> AddDepartment([FromBody] AddDepaertmentCollocationCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> FullUpdateDepartment([FromBody] FullUpdateDepartmentCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
        

        [HttpGet]
        public async Task<IActionResult> GetAllDepartment([FromQuery] GetAllDepartmentsQuery query)
        {
            var departments = await Mediator.Send(query);
            if(departments.Any())
                return Ok(departments);
            return NoContent();
        }
            

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment([FromRoute]int? id)
        {
            if (id == null)
                return BadRequest();
            return Ok(await Mediator.Send(new GetDepartmentQuery { Id = id.Value }));
        }
         


    }
}
