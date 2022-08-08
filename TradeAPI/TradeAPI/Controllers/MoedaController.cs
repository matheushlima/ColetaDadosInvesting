using MediatR;
using Microsoft.AspNetCore.Mvc;
using Trade.Application.Commands;
using Trade.Core.Entities;

namespace Trade.API.Controllers
{
    [Route("api/moeda")]
    public class MoedaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MoedaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] List<MoedaTb> model)
        {
            if(model == null)
                return BadRequest();
            var id = await _mediator.Send(new CreateMoedaCommand(model));

            return Ok(id);
        }
    }
}
