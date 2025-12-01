namespace DesafioFundamentos.Models
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
            Console.WriteLine("Digite a placa do veículo que deseja estacionar:");
            veiculos.Add(Console.ReadLine().ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu estacionado:");

                // Realizar cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = 0;
                decimal valorTotal = 0;

                while (true)
                {
                    var x = Console.ReadLine();
                    //verificacao para evitar erro de espaço em branco ou nulo
                    if (string.IsNullOrWhiteSpace(x))
                    {
                        Console.WriteLine("Por favor, digite um número válido Ex: 5");
                    }
                    else
                    {
                        horas = Convert.ToInt32(x);
                        break;
                    }
                }
                valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo detentor da placa {placa} foi removido! \nO preço total da sua vaga foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não Não foi encontrado, pode não estar estacionado aqui. \nConfira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // Realizar laço de repetição, exibindo os veículos estacionados
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
