using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Csharp
{
    class Veiculo
    {
        private String _Modelo;
        private double _Preco;

        public Veiculo(String modelo, double preco)
        {
            this.Modelo = modelo;
            this.Preco = preco;
        }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; }
        public string Modelo { get; }
    }
}

