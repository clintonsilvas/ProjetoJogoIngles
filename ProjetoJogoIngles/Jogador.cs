using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJogoIngles
{
    internal class Jogador
    {
        private string nome;
        private int pontos;
        private string tempo;

        public string Nome { get => nome; set => nome = value; }
        public int Pontos { get => pontos; set => pontos = value; }
        public string Tempo { get => tempo; set => tempo = value; }
    }
}
