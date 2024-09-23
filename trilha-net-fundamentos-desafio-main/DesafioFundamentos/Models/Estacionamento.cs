using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        // Variáveis
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

        // Construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        // Método para adicionar um veículo
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso.");
        }

        // Método para remover um veículo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"Veículo removido. Valor a ser cobrado: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        // Método para listar veículos
        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
