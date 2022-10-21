using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Park
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Park(decimal _precoInicial, decimal _precoPorHora)
        {
            this.precoInicial = _precoInicial;
            this.precoPorHora = _precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            veiculos.Add(Console.ReadLine()); 
        }

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach(string item in veiculos){
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }   
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {   
                decimal horas = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu:");
                horas = Convert.ToDecimal(Console.ReadLine());

                decimal valorTotal = 0;
                valorTotal = precoInicial + (precoPorHora * horas);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }

        }
    }
}