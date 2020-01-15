using Desafio01_Csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02_Csharp.Model
{
    class Carro : Veiculo
    {
        private String _Marca;
        private int _Portas, _Ano;
        public Carro(String modelo, double preco, String marca, int portas, int ano) : base(modelo, preco)
        {
            this.Marca = marca;
            this.Portas = portas;
            this.Ano = ano;
        }
        public String Marca { get; }
        public int Portas { get; }
        public int Ano { get; }
    }
}
