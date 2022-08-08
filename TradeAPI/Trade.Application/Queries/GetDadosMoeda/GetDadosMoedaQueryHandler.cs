using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;
using Trade.Core.Repositories;

namespace Trade.Application.Queries.GetDados
{
    public class GetDadosMoedaQueryHandler : IRequestHandler<GetDadosMoedaQuery, List<MoedaTb>>
    {
        private readonly IMoedaRepository _moedaRepository;
        public GetDadosMoedaQueryHandler(IMoedaRepository moedaRepository)
        {
            _moedaRepository = moedaRepository;
        }
        public async Task<List<MoedaTb>> Handle(GetDadosMoedaQuery request, CancellationToken cancellationToken)
        {
            return await _moedaRepository.GetAll();
        }
    }
}
