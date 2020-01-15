using Desafio02_Csharp.Model;
using System;

namespace Desafio01_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String marca = "Hyundai", modelo = "HB20";
            bool isligado = false, isAcelerar = false, isFrear = false, isPintar = false;
            int qtdabastecer, combustivel = 100, velocidade = 0, preco = 2;

            Carro meucarro = new Carro("HB20", 20000, "Hyundai", 4, 2010);
            Aviao meuaviao = new Aviao("O que voa", 150000, "Transporte de passageiro", 5, 100);

            Console.WriteLine("STATUS CARRO:");
            Console.WriteLine("Marca: " + meucarro.Marca);
            Console.WriteLine("Modelo: " + meucarro.Modelo);
            Console.WriteLine("Qtd de portas: " + meucarro.Portas);
            Console.WriteLine("Ano: " + meucarro.Ano);
            Console.WriteLine("Preço: R$" + meucarro.Preco);
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("STATUS AVIÃO:");
            Console.WriteLine("Modelo: " + meuaviao.Modelo);
            Console.WriteLine("Tipo: " + meuaviao.Tipo);
            Console.WriteLine("Tempo de Uso: " + meuaviao.Uso);
            Console.WriteLine("Capacidade de sobrevoar: "+meuaviao.Altura+" metros");
            Console.WriteLine("Preço: R$" + meuaviao.Preco);
            Console.WriteLine("___________________________________________________");
        }
    }
}
