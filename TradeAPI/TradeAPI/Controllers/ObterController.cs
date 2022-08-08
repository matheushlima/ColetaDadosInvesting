using MediatR;
using Microsoft.AspNetCore.Mvc;
using Trade.Application.Queries.GetDados;
using Trade.Application.Queries.GetDadosAcao;
using Trade.Core.Entities;

namespace Trade.API.Controllers
{
    [Route("api/obter")]
    public class ObterController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ObterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get(TipoDados model)
        {
            if(model != null)
            {
                if(model.Tipo == "AC")
                {
                    List<AcaoTb> acoes = await _mediator.Send(new GetDadosAcaoQuery());
                    return Ok(acoes);
                }
                else if(model.Tipo == "MO")
                {
                    List<MoedaTb> moedas = await _mediator.Send(new GetDadosMoedaQuery());
                    return Ok(moedas);
                }
                else
                    return BadRequest();
            }
            else
                return BadRequest();
        } 
    }
}
