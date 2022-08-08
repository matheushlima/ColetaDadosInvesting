using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;

namespace Trade.Application.Queries.GetDados
{
    public class GetDadosMoedaQuery : IRequest<List<MoedaTb>>
    {
    }
}
