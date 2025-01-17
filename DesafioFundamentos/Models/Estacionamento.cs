using Microsoft.VisualBasic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        //metodo de adição de veiculos
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Placa = Convert.ToString(Console.ReadLine());
            this.veiculos.Add(Placa);
        }

        //metodo de remoção de veiculos
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Convert.ToString(Console.ReadLine());
            int _veiculo = this.veiculos.IndexOf(placa);

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = this.PrecoInicial + (this.PrecoPorHora*horas); 

                this.veiculos.Remove(veiculos[_veiculo]);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for (int contador= 0; contador<this.veiculos.Count; contador++){
                    Console.WriteLine($"Placa: {this.veiculos[contador]}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}


//finalmente consegui
