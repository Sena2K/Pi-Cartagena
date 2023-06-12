using System.Collections.Generic;

namespace Cartagena
{
    public class Jogada
    {
        public string Carta { get; } // Carta selecionada para a jogada
        public Tabuleiro Tabuleiro { get; } // Tabuleiro atual da jogada
        public Pirata Pirata { get; } // Pirata envolvido na jogada
        public int IndexPirata { get; } // �ndice do pirata na lista de piratas (n�o utilizado no c�digo atual)
        public int Pontuacao { get; set; } // Pontua��o da jogada
        public List<Jogada> JogadasFuturas { get; } // Lista de jogadas futuras

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, string carta, int indexPirata)
        {
            Tabuleiro = new Tabuleiro(tabuleiro); // Cria uma c�pia do tabuleiro atual
            Pirata = pirata.Copiar(); // Cria uma c�pia do pirata
            Carta = carta; // Atribui a carta selecionada
            IndexPirata = indexPirata; // Define o �ndice do pirata (n�o utilizado no c�digo atual)
            Pontuacao = 0; // Inicializa a pontua��o como zero
            JogadasFuturas = new List<Jogada>(); // Inicializa a lista de jogadas futuras vazia
        }

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, int indexPirata)
        {
            Tabuleiro = new Tabuleiro(tabuleiro); // Cria uma c�pia do tabuleiro atual
            Pirata = pirata.Copiar(); // Cria uma c�pia do pirata
            Carta = "voltar"; // Define a carta como "voltar"
            IndexPirata = indexPirata; // Define o �ndice do pirata (n�o utilizado no c�digo atual)
            Pontuacao = 0; // Inicializa a pontua��o como zero
            JogadasFuturas = new List<Jogada>(); // Inicializa a lista de jogadas futuras vazia
        }

        public Jogada(Tabuleiro tabuleiro)
        {
            Tabuleiro = new Tabuleiro(tabuleiro); // Cria uma c�pia do tabuleiro atual
            Carta = "pular"; // Define a carta como "pular"
            Pontuacao = 0; // Inicializa a pontua��o como zero
            JogadasFuturas = new List<Jogada>(); // Inicializa a lista de jogadas futuras vazia
        }

        public void SimularJogada()
        {
            if (Carta == "voltar")
            {
                int posicaoAntiga = Pirata.Local; // Obt�m a posi��o atual do pirata
                int posicaoNova;

                for (posicaoNova = posicaoAntiga - 1; posicaoNova > 0; posicaoNova--)
                {
                    if (Tabuleiro.Posicoes[posicaoNova].NumeroPiratas() > 0 && Tabuleiro.Posicoes[posicaoNova].NumeroPiratas() < 3)
                    {
                        // Move o pirata para a nova posi��o
                        Tabuleiro.Posicoes[posicaoAntiga].Piratas.Remove(Pirata);
                        Pirata.Local = posicaoNova;
                        Tabuleiro.Posicoes[posicaoNova].Piratas.Add(Pirata);
                        break;
                    }
                }
            }
            else
            {
                int posicaoAntiga = Pirata.Local; // Obt�m a posi��o atual do pirata
                int posicaoNova;

                for (posicaoNova = posicaoAntiga; posicaoNova < Tabuleiro.Posicoes.Length - 1; posicaoNova++)
                {
                    if (Carta == Tabuleiro.Posicoes[posicaoNova].Tipo && Tabuleiro.Posicoes[posicaoNova].Piratas.Count == 0)
                    {
                        break;
                    }
                }

                // Move o pirata para a nova posi��o
                Tabuleiro.Posicoes[posicaoAntiga].Piratas.Remove(Pirata);
                Pirata.Local = posicaoNova;
                Tabuleiro.Posicoes[posicaoNova].Piratas.Add(Pirata);
            }
        }
    }
}
