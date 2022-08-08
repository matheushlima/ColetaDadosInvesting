using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;
using Trade.Core.Repositories;

namespace Trade.Application.Queries.GetDadosAcao
{
    public class GetDadosAcaoQueryHandler : IRequestHandler<GetDadosAcaoQuery, List<AcaoTb>>
    {
        private readonly IAcaoRepository _acaoRepository;
        public GetDadosAcaoQueryHandler(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }
        public Task<List<AcaoTb>> Handle(GetDadosAcaoQuery request, CancellationToken cancellationToken)
        {
            return _acaoRepository.GetAll();
        }
    }
}
