using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RoboCotacao.Services.Dados
{
    public static class ConfigDriver
    {
        public static IWebDriver? Config()
        {
            try
            {
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--headless");

                var path = Directory.GetCurrentDirectory();

                IWebDriver driver = new ChromeDriver($@"{path}\Driver", chromeOptions);

                driver.Manage().Timeouts().PageLoad =
                       TimeSpan.FromSeconds(60);

                return driver;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não possivel configurar o driver para a utilização do Selenium!\nERRO: {ex.Message}");
                return null;
            }
            
        }
        
    }

    
}
