using MediatR;
using Microsoft.AspNetCore.Mvc;
using Trade.Application.Commands;
using Trade.Core.Entities;
using Trade.Infrastructure.Models;

namespace Trade.API.Controllers
{
    [Route("api/acao")]
    public class AcaoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AcaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] List<AcaoTb> model)
        {
            if (model == null)
                return BadRequest();

            await _mediator.Send(new CreateAcaoCommand(model));

            return Ok();
        }
    }
}
