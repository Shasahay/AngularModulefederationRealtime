using Management.Services.Student.Core.Features.Queries;
using Management.Services.Student.Core.Models.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Management.Services.Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)  => this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet(Name ="GetAllStudents")]
        public async Task<IActionResult> GetStudents(CancellationToken cancellationToken)
        {
            var result =  await _mediator.Send(new GetStudentQuery { }, cancellationToken);
            return Ok(result);
        }

    }
}
