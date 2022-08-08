using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;

namespace Trade.Core.Repositories
{
    public interface IMoedaRepository
    {
        Task<List<MoedaTb>> GetAll();
        Task CreateAsync(List<MoedaTb> moedaTb);
    }
}
