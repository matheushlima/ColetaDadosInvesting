using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Application.InputModels
{
    public class NewAcaoInputModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Ultimo { get; set; }
        public string Maxima { get; set; }
        public string Minima { get; set; }
        public string Variacao { get; set; }
        public string VariacaoPorcent { get; set; }
        public string Volume { get; set; }
        public string Hora { get; set; }
    }
}
