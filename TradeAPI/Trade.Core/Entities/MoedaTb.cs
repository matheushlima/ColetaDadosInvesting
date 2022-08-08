using System;
using System.Collections.Generic;

namespace Trade.Core.Entities
{
    public partial class MoedaTb
    {
        public MoedaTb(string nome, string? compra, string? venda, string? maxima, string? minima, string? variacao, string? variacaoPorcent, DateTime? dataHora)
        {
            Nome = nome;
            Compra = compra;
            Venda = venda;
            Maxima = maxima;
            Minima = minima;
            Variacao = variacao;
            VariacaoPorcent = variacaoPorcent;
            DataHora = dataHora;
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Compra { get; set; }
        public string? Venda { get; set; }
        public string? Maxima { get; set; }
        public string? Minima { get; set; }
        public string? Variacao { get; set; }
        public string? VariacaoPorcent { get; set; }
        public DateTime? DataHora { get; set; }
    }
}
