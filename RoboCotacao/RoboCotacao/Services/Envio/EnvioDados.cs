using Newtonsoft.Json;
using RoboCotacao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCotacao.Services.Envio
{
    public static class EnvioDados
    {
        public static async Task<bool> EnviaDadosMoeda(List<Moeda> moedas)
        {
            var moedasJson = JsonConvert.SerializeObject(moedas);
            var dados = new StringContent(moedasJson, Encoding.Default, "application/json");

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://localhost:5180");

                var response = client.PostAsync(@"/api/moeda", dados).Result;

                return response.IsSuccessStatusCode;
            }
        }

        public static async Task<bool> EnviaDadosAcao(List<Acoes> acoes)
        {
            var acoesJson = JsonConvert.SerializeObject(acoes);
            var dados = new StringContent(acoesJson, Encoding.Default, "application/json");

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://localhost:5180");

                HttpResponseMessage response = client.PostAsync(@"/api/acao", dados).Result;

                return response.IsSuccessStatusCode;
            }
        }

    }
}
