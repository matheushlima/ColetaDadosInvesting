using RoboCotacao.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCotacao.Entities
{
    public class Acoes : IDados
    {
        public string Nome { get; set; }
        public string Maxima { get; set; }
        public string Minima { get; set; }
        public string Variacao { get; set; }
        public string VariacaoPorcentagem { get; set; }
        public string Hora { get; set; }
        public string Ultimo { get; set; }
        public string Volume { get; set; }
    }
}
