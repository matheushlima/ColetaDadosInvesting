using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Application.InputModels
{
    public class NewMoedaInputModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Compra { get; set; }
        public string Venda { get; set; }
        public string Maxima { get; set; }
        public string Minima { get; set; }
        public string Variacao { get; set; }
        public string VariacaoPorcent { get; set; }
        public string Hora { get; set; }
    }
}
