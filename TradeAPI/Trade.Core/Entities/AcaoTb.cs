using System;
using System.Collections.Generic;

namespace Trade.Core.Entities
{
    public partial class AcaoTb
    {
        public AcaoTb(string nome, string? ultimo, string? maxima, string? minima, string? variacao, string? variacaoPorcent, string? volume, DateTime? dataHora)
        {
            Nome = nome;
            Ultimo = ultimo;
            Maxima = maxima;
            Minima = minima;
            Variacao = variacao;
            VariacaoPorcent = variacaoPorcent;
            Volume = volume;
            DataHora = dataHora;
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Ultimo { get; set; }
        public string? Maxima { get; set; }
        public string? Minima { get; set; }
        public string? Variacao { get; set; }
        public string? VariacaoPorcent { get; set; }
        public string? Volume { get; set; }
        public DateTime? DataHora { get; set; }
    }
}
