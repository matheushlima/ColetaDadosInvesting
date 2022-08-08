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
    public class AcaoRepository : IAcaoRepository
    {
        private readonly tradeContext _tradeContext;
        public AcaoRepository(tradeContext tradeContext)
        {
            _tradeContext = tradeContext;
        }
        public async Task CreateAsync(List<AcaoTb> moedaTb)
        {
            await _tradeContext.AcaoTbs.AddRangeAsync(moedaTb);
            await _tradeContext.SaveChangesAsync();
        }

        public Task<List<AcaoTb>> GetAll()
        {
            return _tradeContext.AcaoTbs.ToListAsync();
        }
    }
}
