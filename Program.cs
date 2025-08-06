using GerenciadorDeEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "\nDigite o preço inicial R$:");

while (!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial < 0)
{
    Console.WriteLine("❌ Valor inválido. Por favor, digite um valor numérico positivo para o preço inicial:");
}

Console.WriteLine("\nAgora digite o preço por hora:");
while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)
{
    Console.WriteLine("❌ Valor inválido. Por favor, digite um valor numérico positivo para o preço por hora:");
}

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

var exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("MENU Sistema de Estacionamento:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("\nEscolha uma opção do Menu: ");
    
    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");