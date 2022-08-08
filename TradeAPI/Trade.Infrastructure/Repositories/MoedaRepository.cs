using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Core.Entities;
using Trade.Core.Repositories;
using Trade.Infrastructure.Models;

namespace Trade.Infrastructure.Repositories
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly tradeContext _tradeContext;
        public MoedaRepository(tradeContext tradeContext)
        {
            _tradeContext = tradeContext;
        }
        public async Task CreateAsync(List<MoedaTb> moedaTb)
        {
            await _tradeContext.MoedaTbs.AddRangeAsync(moedaTb);
            await _tradeContext.SaveChangesAsync();
        }

        public Task<List<MoedaTb>> GetAll()
        {
            return _tradeContext.MoedaTbs.ToListAsync();
        }
    }
}
