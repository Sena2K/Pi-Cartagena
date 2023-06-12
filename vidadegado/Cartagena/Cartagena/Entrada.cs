using System;

namespace Cartagena
{
    class Entrada
    {
        public Jogada Jogada { get; set; }
        public int Chave { get; set; }

        public Entrada(Jogada jogada, int chave)
        {
            Jogada = jogada;
            Chave = chave;
        }
    }
}
