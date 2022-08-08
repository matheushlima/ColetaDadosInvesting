using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;

namespace Trade.Application.Commands
{
    public class CreateAcaoCommand : IRequest<Unit>
    {
        public CreateAcaoCommand(List<AcaoTb> acaoTbs)
        {
            AcaoTbs = acaoTbs;
        }
        public List<AcaoTb> AcaoTbs { get; set; }
    }
}
