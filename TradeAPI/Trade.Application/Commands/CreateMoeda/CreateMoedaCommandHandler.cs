using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;
using Trade.Core.Repositories;

namespace Trade.Application.Commands.CreateMoeda
{
    public class CreateMoedaCommandHandler : IRequestHandler<CreateMoedaCommand, Unit>
    {
        private readonly IMoedaRepository _moedaRepository;
        public CreateMoedaCommandHandler(IMoedaRepository moedaRepository)
        {
            _moedaRepository = moedaRepository;
        }

        public async Task<Unit> Handle(CreateMoedaCommand request, CancellationToken cancellationToken)
        {
            await _moedaRepository.CreateAsync(request.Moedas);

            return Unit.Value;
        }
    }
}
