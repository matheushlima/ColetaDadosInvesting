using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCotacao.Entities.Interface
{
    public interface IDados
    {
         string Nome { get; set; }
         string Maxima { get; set; }
         string Minima { get; set; }
         string Variacao { get; set; }
         string VariacaoPorcentagem { get; set; }
         string Hora { get; set; }
    }
}
