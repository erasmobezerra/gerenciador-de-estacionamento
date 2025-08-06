namespace GerenciadorDeEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string? placaVeiculo = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                Console.WriteLine("❌ Placa inválida. Tente novamente.");
                return;
            }

            if (veiculos.Contains(placaVeiculo))
            {
                Console.WriteLine("⚠️ Este veículo já está estacionado.");
                return;
            }

            veiculos.Add(placaVeiculo);
            Console.WriteLine("✅ Veículo estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string? placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("❌ Placa inválida. Tente novamente.");
                return;
            }
         
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (!int.TryParse(Console.ReadLine(), out int horas) || horas < 0)
                {
                    Console.WriteLine("❌ Entrada inválida. Tente novamente.");
                    return;
                }
                
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                    Console.WriteLine("- " + veiculo);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
