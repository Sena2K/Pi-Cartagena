using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;

namespace Cartagena
{
    class Partida
    {
        // Propriedades com letras maiúsculas para seguir convenções de nomenclatura
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public string Senha { get; private set; }
        public Tabuleiro Tabuleiro { get; private set; }
        public Ronaizer Ronaizer { get; private set; }
        public List<Inimigo> Inimigos { get; private set; }

        // Propriedades em minúsculas para acesso aos dados
        public string nome { get { return Nome; } }
        public int id { get { return Id; } }
        public string senha { get { return Senha; } }
        public Tabuleiro tabuleiro { get { return Tabuleiro; } }
        public Ronaizer ronaizer { get { return Ronaizer; } }
        public List<Inimigo> inimigos { get { return Inimigos; } }

        public Partida(int id, string nome, string senha, int idJogador, string nomeJogador, string senhaJogador)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Inimigos = new List<Inimigo>();

            // Obter a lista de jogadores da partida
            string[] listaJogadores = Jogo.ListarJogadores(id).Split('\n');

            // Iterar sobre a lista de jogadores e criar objetos Ronaizer e Inimigo
            for (int i = 0; i < listaJogadores.Length - 1; i++)
            {
                string[] atributosJogador = listaJogadores[i].Replace("\r", "").Split(',');

                int idInimigo = Convert.ToInt16(atributosJogador[0]);
                string nomeInimigo = atributosJogador[1];
                string cor = atributosJogador[2];

                if (idInimigo != idJogador)
                {
                    Inimigo inimigo = new Inimigo(idInimigo, nomeInimigo, cor);
                    Inimigos.Add(inimigo);
                }
                else
                {
                    Ronaizer = new Ronaizer(idJogador, nomeJogador, cor, senhaJogador);
                }
            }

            // Criar o objeto Tabuleiro com base nos dados obtidos
            Tabuleiro = new Tabuleiro(Id, Ronaizer.piratas, Inimigos);
        }

        public void AtualizarPosicoesDosPiratas(string vez)
        {
            // Limpar os piratas das posições
            foreach (Posicao posicao in Tabuleiro.Posicoes)
            {
                posicao.Piratas.Clear();
            }

            // Reinicializar o array de piratas do Ronaizer
            Ronaizer.piratas = new Pirata[6];
            int index = 0;
            string[] posicoes, jogadas;
            jogadas = vez.Split('\n');

            // Iterar sobre as jogadas para atualizar os dados do Ronaizer e dos Inimigos
            for (int i = 1; i < jogadas.Length - 1; i++)
            {
                jogadas[i] = jogadas[i].Replace("\r", "");
                posicoes = jogadas[i].Split(',');

                int posicao = Convert.ToInt16(posicoes[0]),
                    idJogador = Convert.ToInt16(posicoes[1]),
                    numeroPiratas = Convert.ToInt16(posicoes[2]);

                if (idJogador == Ronaizer.id)
                {
                    // Criar os piratas do Ronaizer e atualizar as posições
                    for (int j = 0; j < numeroPiratas; j++)
                    {
                        Pirata pirata = new Pirata(Ronaizer.cor, posicao);
                        Ronaizer.piratas[index] = pirata;
                        index++;
                        Tabuleiro.Posicoes[posicao].Piratas.Add(pirata);
                    }
                }
            }

            // Atualizar os dados dos Inimigos
            foreach (Inimigo inimigo in Inimigos)
            {
                index = 0;
                inimigo.piratas = new Pirata[6];

                for (int i = 1; i < jogadas.Length - 1; i++)
                {
                    posicoes = jogadas[i].Split(',');

                    int posicao = Convert.ToInt16(posicoes[0]),
                        idJogador = Convert.ToInt16(posicoes[1]),
                        numeroPiratas = Convert.ToInt16(posicoes[2]);

                    if (idJogador == inimigo.id)
                    {
                        // Criar os piratas do Inimigo e atualizar as posições
                        for (int j = 0; j < numeroPiratas; j++)
                        {
                            Pirata pirata = new Pirata(inimigo.cor, posicao);
                            inimigo.piratas[index] = pirata;
                            index++;
                            Tabuleiro.Posicoes[posicao].Piratas.Add(pirata);
                        }
                    }
                }
            }
        }
    }
}
