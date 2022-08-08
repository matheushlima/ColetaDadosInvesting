using OpenQA.Selenium;
using RoboCotacao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCotacao.Services.Dados
{
    public static class GetDadosAcao
    {
        public static List<Acoes> GetDados(IWebDriver driver)
        {
            List<Acoes> acoes = new List<Acoes>();

            try
            {
                driver.Navigate().GoToUrl("https://br.investing.com/equities/brazil");

                var rowCotacoes = driver
                    .FindElement(By.Id("cross_rate_markets_stocks_1"))
                    .FindElement(By.TagName("tbody"))
                    .FindElements(By.TagName("tr"));

                
                foreach (var row in rowCotacoes)
                {
                    Acoes acao = new Acoes();

                    var dados = row.FindElements(By.TagName("td"));

                    acao.Nome = dados[1].Text;
                    acao.Ultimo = dados[2].Text;
                    acao.Maxima = dados[3].Text;
                    acao.Minima = dados[4].Text;
                    acao.Variacao = dados[5].Text;
                    acao.VariacaoPorcentagem = dados[6].Text;
                    acao.Volume = dados[7].Text;
                    acao.Hora = DateTime.Now.ToString();

                    acoes.Add(acao);
                }

                return acoes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível obter os dados da tabela de moedas!\nERRO: {ex.Message}");
                return acoes;
            }
        }
    }
}
