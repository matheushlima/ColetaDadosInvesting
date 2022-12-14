using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;

namespace Trade.Application.Commands
{
    public class CreateMoedaCommand : IRequest<Unit>
    {
        public CreateMoedaCommand(List<MoedaTb> moedas)
        {
            Moedas = moedas;
        }
        
        public List<MoedaTb> Moedas { get; set; }
    }
}
