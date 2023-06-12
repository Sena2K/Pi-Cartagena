using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;
namespace Cartagena
{
    public class ronaizer
    {
        protected int _id { get; set; }
        protected string _nome { get; set; }
        protected string _cor { get; set; }

        Pen penRed = new Pen(Brushes.Red);
        Pen penGreen = new Pen(Brushes.Green);
        Pen penYellow = new Pen(Brushes.Yellow);
        Pen penBlue = new Pen(Brushes.Blue);
        Pen penBrown = new Pen(Brushes.SaddleBrown);

        public Pirata[] piratas;

        public int id
        {
            get { return _id; }
        }

        public string nome
        {
            get { return _nome; }
        }

        public string cor
        {
            get { return _cor; }
        }

        public List<Pirata> ObterPiratasNaPosicao(int posicao)
        {
            List<Pirata> piratasNaPosicao = new List<Pirata>();

            foreach (Pirata pirata in piratas)
            {
                if (pirata.Local == posicao)
                {
                    piratasNaPosicao.Add(pirata);
                }
            }

            return piratasNaPosicao;
        }

        public void DesenharPirata(Graphics g, string corJogador, int xPirata, int yPirata)
        {
            Pen pen;

            if (corJogador == "Vermelho")
            {
                pen = new Pen(Color.Red, 8.0F);
            }
            else if (corJogador == "Verde")
            {
                pen = new Pen(Color.Green, 8.0F);
            }
            else if (corJogador == "Amarelo")
            {
                pen = new Pen(Color.Yellow, 8.0F);
            }
            else if (corJogador == "Azul")
            {
                pen = new Pen(Color.Blue, 8.0F);
            }
            else if (corJogador == "Marrom")
            {
                pen = new Pen(Color.Brown, 8.0F);
            }
            else
            {
                // Cor padrão caso a cor do jogador não seja reconhecida
                pen = new Pen(Color.Black, 8.0F);
            }

            g.DrawEllipse(pen, new Rectangle(xPirata, yPirata, 5, 5));
        }



        public void desenharPiratas(Tabuleiro tabuleiro, PictureBox[] casaTabuleiro)
        {
            PictureBox[] posicaoTabuleiro = casaTabuleiro;

            foreach (Posicao posicao in tabuleiro.Posicoes)
            {
                int xPirata = 5, yPirata = 5;
                foreach (Pirata pirata in posicao.Piratas)
                {
                    if (pirata.Local == 0 || pirata.Local == 37) { }
                    else
                    {
                        string playerCor = pirata.Cor;
                        Graphics g = posicaoTabuleiro[pirata.Local].CreateGraphics();
                        this.DesenharPirata(g,playerCor, xPirata,yPirata);
                        xPirata += 15;
                        yPirata +=15;
                    }
                }

            }

        }

        public override string ToString()
        {
            string toString;
            toString = _nome + " (" + _cor + ")" + ": ";
            foreach (Pirata pirata in piratas)
            {
                toString += pirata.Local.ToString() + " ";
            }

            return toString;
        }
    }

    public class Inimigo : ronaizer
    {
        public Inimigo(int id, string nome, string cor)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            piratas = new Pirata[]
            {
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor)
            };
        }
    }

    public class Ronaizer : ronaizer
    {

        string _senha { get; set; }
        public List<string> cartas;

        public string senha
        {
            get { return _senha; }
        }

        public Ronaizer(int id, string nome, string cor, string senha)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            _senha = senha;
            piratas = new Pirata[]
            {
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor)
            };
            this.cartas = new List<string>();

            string[] ronaizerCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < ronaizerCartas.Length - 1; i++)
            {
                string[] cartas = ronaizerCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }
            }

        }

        public void jogar(Jogada jogada)
        {
            Pirata pirata = piratas[jogada.IndexPirata];
            string carta = jogada.Carta;
            
            cartas.Remove(carta);

            
            Cartagena.LidarErros(Jogo.Jogar(id, senha, pirata.Local, carta));
            
            
        }

        public void voltarPirata(Jogada jogada)
        {

            Pirata pirata = piratas[jogada.IndexPirata];


            Cartagena.LidarErros(Jogo.Jogar(id, senha, pirata.Local));

        }

        public void pularJogada()
        {
            Console.WriteLine("Jogada pulada!");
            Cartagena.LidarErros(Jogo.Jogar(id, senha));
        }

        public void atualizarCartas()
        {
            this.cartas = new List<string>();

            string[] ronaizerCartas = Jogo.ConsultarMao(_id, _senha).Split('\n');

            for (int i = 0; i < ronaizerCartas.Length - 1; i++)
            {
                string[] cartas = ronaizerCartas[i].Replace("\r", "").Split(',');
                for (int j = 0; j < Convert.ToInt32(cartas[1]); j++)
                {
                    this.cartas.Add(cartas[0]);
                }
            }
        }

        public Jogada AvaliarMelhorJogada(Tabuleiro tabuleiro)
        {
            int estagioAvaliacao = 0;
            bool avaliacao = false;
            Jogada jogada;
            ListaDecisoes prioridades = new ListaDecisoes();
            List<Jogada> jogadasPossiveis = gerarJogadas(tabuleiro);

            foreach(Jogada j in jogadasPossiveis)
            {
               
            }

            while (avaliacao != true)
            {
                switch (estagioAvaliacao)
                {
                    case 0:
                        AvaliarJogada(jogadasPossiveis);
                        estagioAvaliacao += 1;
                        break;
                    case 1: 
                        prioridades = adicionarNaLista(jogadasPossiveis);
                        estagioAvaliacao += 1;
                        break;
                    case 2: 
                        avaliacao = true;
                        break;
                }
            }

            jogada = prioridades.RemoverUltimaJogada();
            return jogada;

        }

        private List<Jogada> gerarJogadas(Tabuleiro tabuleiro)
        {
            List<Jogada> jogadas = new List<Jogada>();
            int index = 0;
            

            jogadas.Add(new Jogada(tabuleiro));
            
            foreach (Pirata pirata in piratas)
            {
                Jogada jogada;

                
                if (pirata.Local == 37)
                {
                    continue;
                }

                if (pirata.Local == 0 || !tabuleiro.ExistemPiratasAntesDe(pirata.Local))
                {
                    foreach (string carta in cartas)
                    {
                        jogada = new Jogada(tabuleiro, pirata, carta, index);
                        jogada.SimularJogada();
                        jogadas.Add(jogada);
                    }
                }
                else
                {
                    jogada = new Jogada(tabuleiro, pirata, index);
                    jogada.SimularJogada();
                    jogadas.Add(jogada);
                    foreach (string carta in cartas)
                    {
                        jogada = new Jogada(tabuleiro, pirata, carta, index);
                        jogada.SimularJogada();
                        jogadas.Add(jogada);
                    }
                }
                index++;
            }
            return jogadas;
        }

        private void AvaliarJogada(List<Jogada> jogadasPossiveis)
        {
            Jogada melhorJogada = jogadasPossiveis[0];
            int diferencaPosicaoMaxima = 0;
            int menorPosicao = piratas[0].Local;
            int somaPosicoes = piratas.Sum(p => p.Local);
            int mediaPosicoes = somaPosicoes / piratas.Length;
            int menorDiferencaPosicaoAnterior = 38;

            foreach (Pirata pirata in piratas)
            {
                if (pirata.Local < menorPosicao)
                {
                    menorPosicao = pirata.Local;
                }
            }

            for (int i = piratas.Length - 1; i > 0; i--)
            {
                int diferencaPosicaoAnterior = piratas[i].Local - piratas[i - 1].Local;
                if (piratas[i].Local != 37 && diferencaPosicaoAnterior <= menorDiferencaPosicaoAnterior)
                {
                    menorDiferencaPosicaoAnterior = diferencaPosicaoAnterior;
                }
            }

            foreach (Jogada jogada in jogadasPossiveis)
            {
                if (jogada.Carta == "pular" || (cartas.Count > 5 && jogada.Carta == "voltar"))
                {
                    continue;
                }

                Pirata pirata = jogada.Pirata;
                Tabuleiro tabuleiro = jogada.Tabuleiro;

                if (piratas[jogada.IndexPirata].Local == 0)
                {
                    jogada.Pontuacao += 7;
                }

                int diferencaPosicao = pirata.Local - piratas[jogada.IndexPirata].Local;
                if (diferencaPosicao > diferencaPosicaoMaxima)
                {
                    melhorJogada = jogada;
                    diferencaPosicaoMaxima = diferencaPosicao;
                }

                if (cartas.Count < 3 && jogada.Carta == "voltar")
                {
                    if (tabuleiro.Posicoes[pirata.Local].NumeroPiratas() > 2)
                    {
                        jogada.Pontuacao += 2;
                    }

                    if (piratas[jogada.IndexPirata].Local > mediaPosicoes)
                    {
                        jogada.Pontuacao += 2;
                    }

                    if (cartas.Count == 0)
                    {
                        jogada.Pontuacao += 3;
                    }

                    if (piratas[jogada.IndexPirata].Local == menorDiferencaPosicaoAnterior)
                    {
                        jogada.Pontuacao += 4;
                    }

                    jogada.Pontuacao += 4;
                }

                if (jogada.Carta != "voltar")
                {
                    if (jogada.IndexPirata == menorPosicao)
                    {
                        jogada.Pontuacao += 6;
                    }

                    if (piratas[jogada.IndexPirata].Local < mediaPosicoes)
                    {
                        jogada.Pontuacao += 6;
                    }

                    if (piratas[jogada.IndexPirata].Local < 17)
                    {
                        jogada.Pontuacao += 5;
                    }

                    if (pirata.Local == 37)
                    {
                        jogada.Pontuacao += 10;
                    }
                }
            }

            melhorJogada.Pontuacao += 6;
        }




        //Adiciona e ordena as jogadas na lista de decisoes.
        private ListaDecisoes adicionarNaLista(List<Jogada> jogadasPossiveis)
        {
            ListaDecisoes listadedecisoes = new ListaDecisoes();
            foreach (Jogada jogadaPossivel in jogadasPossiveis)
            {
                listadedecisoes.InserirJogadaPrioritária(jogadaPossivel, jogadaPossivel.Pontuacao);
            }

            return listadedecisoes;

        }
        
        public override string ToString()
        {
            string toString;
            toString = _nome + " (" + _cor + ")" + ": ";
            foreach (Pirata pirata in piratas)
            {
                toString += pirata.Local.ToString() + " ";
            }
            toString += " | Cartas: ";
            foreach (string carta in cartas)
            {
                toString += carta + " ";
            }

            return toString;
        }
        
    }
}
