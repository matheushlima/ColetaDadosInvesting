using OpenQA.Selenium;
using RoboCotacao.Entities;

namespace RoboCotacao.Services.Dados
{
    public static class GetDadosMoeda
    {
        public static List<Moeda> GetDados(IWebDriver driver)
        {
            List<Moeda> moedas = new List<Moeda>();

            try
            {
                driver.Navigate().GoToUrl("https://br.investing.com/currencies/streaming-forex-rates-majors");

                var rowCotacoes = driver
                    .FindElement(By.Id("cr1"))
                    .FindElement(By.TagName("tbody"))
                    .FindElements(By.TagName("tr"));

                
                foreach (var row in rowCotacoes)
                {
                    Moeda moeda = new Moeda();

                    var dados = row.FindElements(By.TagName("td"));

                    moeda.Nome = dados[1].Text;
                    moeda.Compra = dados[2].Text;
                    moeda.Venda = dados[3].Text;
                    moeda.Maxima = dados[4].Text;
                    moeda.Minima = dados[5].Text;
                    moeda.Variacao = dados[6].Text;
                    moeda.VariacaoPorcentagem = dados[7].Text;
                    moeda.Hora = DateTime.Now.ToString();

                    moedas.Add(moeda);
                }

                return moedas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível obter os dados da tabela de moedas!\nERRO: {ex.Message}");
                return moedas;
            }
        }
    }
}
