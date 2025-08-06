namespace GerenciadorDeEstacionamento.Models
{
    public class Estacionamento
    {
        private readonly decimal _precoInicial = 0;
        private readonly decimal _precoPorHora = 0;
        private readonly List<string> _veiculos = [];

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this._precoInicial = precoInicial;
            this._precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            var placaVeiculo = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                Console.WriteLine("❌ Placa inválida. Tente novamente.");
                return;
            }

            if (_veiculos.Contains(placaVeiculo))
            {
                Console.WriteLine("⚠️ Este veículo já está estacionado.");
                return;
            }

            _veiculos.Add(placaVeiculo);
            Console.WriteLine("✅ Veículo estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            var placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("❌ Placa inválida. Tente novamente.");
                return;
            }
         
            if (_veiculos.Any(x => string.Equals(x, placa, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (!int.TryParse(Console.ReadLine(), out var horas) || horas < 0)
                {
                    Console.WriteLine("❌ Entrada inválida. Tente novamente.");
                    return;
                }
                
                var valorTotal = _precoInicial + (_precoPorHora * horas);
                _veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (_veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in _veiculos)
                    Console.WriteLine("- " + veiculo);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
