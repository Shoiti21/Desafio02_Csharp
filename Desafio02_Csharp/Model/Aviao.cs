using Desafio01_Csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02_Csharp.Model
{
    class Aviao : Veiculo
    {
        private String _Tipo;
        private int _Uso, _Altura;
        public Aviao(String modelo, double preco, String tipo, int uso, int altura) : base(modelo, preco)
        {
            this.Tipo = tipo;
            this.Uso = uso;
            this.Altura = altura;
        }
        public String Tipo{ get; }
        public int Uso { get; }
        public int Altura { get; }
    }
}
