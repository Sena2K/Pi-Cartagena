using System;
using System.Collections.Generic;
using CartagenaServer;

namespace Cartagena
{
    public class Tabuleiro
    {
        public Posicao[] Posicoes; // Array de posições do tabuleiro

        public Tabuleiro(int id, Pirata[] pirastasRonaizer, List<Inimigo> inimigos)
        {
            Posicoes = new Posicao[38];
            string output = Jogo.ExibirTabuleiro(Convert.ToInt32(id));

            string[] linha = output.Split('\r');

            Posicoes[0] = new Posicao("Prisão", pirastasRonaizer, inimigos);

            for (int i = 1; i < 37; i++)
            {
                linha[i] = linha[i].Replace("\n", "");
                string[] tipo = linha[i].Split(',');
                Posicoes[i] = new Posicao(tipo[1]);
            }

            Posicoes[37] = new Posicao("Barco");
        }

        public Tabuleiro(Tabuleiro tabuleiro)
        {
            Posicoes = new Posicao[38];
            int index = 0;

            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                Posicoes[index] = posicao.Copiar();
                index++;
            }
        }

        public bool ExistemPiratasAntesDe(int local)
        {
            for (local -= 1; local > 0; local--)
            {
                if (Posicoes[local].NumeroPiratas() > 0 && Posicoes[local].NumeroPiratas() < 3)
                {
                    return true;
                }
            }
            return false;
        }

        public int PosicaoPirataAnterior(int local)
        {
            if (!ExistemPiratasAntesDe(local))
            {
                return -38;
            }

            for (local = local - 1; local > 0; local--)
            {
                if (Posicoes[local].NumeroPiratas() > 0 && Posicoes[local].NumeroPiratas() < 3)
                {
                    return local;
                }
            }

            return local;
        }

        public override string ToString()
        {
            string toString = "";
            foreach (Posicao posicao in Posicoes)
            {
                toString += posicao.ToString() + " ";
            }
            return toString;
        }
    }

    public class Posicao
    {
        public List<Pirata> Piratas; // Lista de piratas na posição
        public string Tipo { get; set; } // Tipo da posição

        public Posicao(string tipo, Pirata[] piratasRonaizer, List<Inimigo> inimigos)
        {
            Tipo = tipo;
            Piratas = new List<Pirata>();

            foreach (Pirata pirata in piratasRonaizer)
            {
                Piratas.Add(pirata);
            }

            foreach (Inimigo inimigo in inimigos)
            {
                foreach (Pirata pirata in inimigo.piratas)
                {
                    Piratas.Add(pirata);
                }
            }
        }

        public Posicao(string tipo, List<Pirata> piratas)
        {
            Tipo = tipo;
            Piratas = new List<Pirata>(piratas);
        }

        public Posicao(string tipo)
        {
            Tipo = tipo;
            Piratas = new List<Pirata>();
        }

        public int NumeroPiratas()
        {
            return Piratas.Count;
        }

        public Posicao Copiar()
        {
            return new Posicao(Tipo, new List<Pirata>(Piratas));
        }

        public override string ToString()
        {
            string toString = "[" + Tipo;

            foreach (Pirata pirata in Piratas)
            {
                toString += " (" + pirata.Cor + ") ";
            }

            toString += "]";
            return toString;
        }
    }
}
