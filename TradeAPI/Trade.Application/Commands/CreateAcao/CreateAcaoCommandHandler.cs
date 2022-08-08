using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;
using Trade.Core.Repositories;

namespace Trade.Application.Commands.CreateAcao
{
    internal class CreateAcaoCommandHandler : IRequestHandler<CreateAcaoCommand, Unit>
    {
        private readonly IAcaoRepository _acaoRepository;
        public CreateAcaoCommandHandler(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public async Task<Unit> Handle(CreateAcaoCommand request, CancellationToken cancellationToken)
        {
            await _acaoRepository.CreateAsync(request.AcaoTbs);

            return Unit.Value;
        }
    }
}
