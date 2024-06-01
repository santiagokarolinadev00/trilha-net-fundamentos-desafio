namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoHora = 0;
        public List<string> veiculos = new List<string>();

        public Estacionamento(List<string> veiculos, decimal precoHora, decimal precoInicial)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = veiculos;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja estacionar");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover");
            string placa = Console.ReadLine();

            // Verifica se veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo passou estacionado");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = horas * precoHora + precoInicial;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total a pagar foi de R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou o número da placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados aqui são:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados aqui por enquanto");
            }
        }
    }
}
