using RoboCotacao.Services.Dados;
using RoboCotacao.Services.Envio;

bool enviouDadosMoedas = false;
bool enviouDadosAcoes = false;
bool sair = false;

Console.WriteLine("Iniciando as configurações do Robô.\nObtendo o driver...");
var driver = ConfigDriver.Config();

ThreadStart tsMoeda = new (ExecutaThreadMoeda);
ThreadStart tsAcao = new (ExecutaThreadAcao);

Thread tMoeda = new (tsMoeda);
Thread tAcao = new (tsAcao);

if (driver != null)
{
    Console.WriteLine("\nATENÇÃO\nPara parar o robô após sua inicialização, apertar a tecla 'ENTER'");
    Console.WriteLine("\nDriver configurado com suceso");
    Console.WriteLine("\nPara iniciar o robô, digite '1'\nPara cancelar o processo, digite '2'");
    int escolha = int.Parse(Console.ReadLine());


    if(escolha == 1)
    {
        Console.WriteLine("Robo em execução!");
                
         tAcao.Start();
         tMoeda.Start();

         sair = Console.ReadKey().Key == ConsoleKey.Enter;
        
    }
    else if(escolha == 2)
        driver.Close();
    else
    {
        Console.WriteLine("Opção invalida! Encerrando processo...");
        driver.Close();
    }
}

//driver?.Close();

async void ExecutaThreadMoeda()
{
    while (!sair)
    {
        var moedas = GetDadosMoeda.GetDados(driver);

        if (moedas != null)
            enviouDadosMoedas = await EnvioDados.EnviaDadosMoeda(moedas);

        if (enviouDadosMoedas)
            Console.WriteLine("Dados das moedas enviados!!");

        enviouDadosMoedas = false;
        Thread.Sleep(3000);
    }

}

async void ExecutaThreadAcao()
{
    while (!sair)
    {
        var acoes = GetDadosAcao.GetDados(driver);

        if (acoes != null)
            enviouDadosAcoes = await EnvioDados.EnviaDadosAcao(acoes);

        if (enviouDadosAcoes)
            Console.WriteLine("Dados das ações enviados com sucesso!!");

        enviouDadosAcoes = false;
        Thread.Sleep(3000);
    }

}

