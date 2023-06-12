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
    public partial class Cartagena : Form
    {
        public static string[] cartasTabuleiro = new string[38];
        public static string[] idJogadores = new string[5];
        public static string[] tabuleiro = new string[38];
        public PictureBox[] casaTabuleiro = new PictureBox[38];
        public const int pcbEixoX = 575;
        public const int pcbEixoY = 15;

        Partida partidaAtiva;

        public Cartagena()
        {
            InitializeComponent();
        }

        public void criarInterfaceTabuleiro()
        {
            int positionX = pcbEixoX;
            int positionY = pcbEixoY;
            int row = 0;
            bool inverteRow = false;

            for (int i = 1; i < 37; i++)
            {
                casaTabuleiro[i] = new PictureBox();

                // Verificar o Tipo da posição no tabuleiro
                if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "C")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/chave.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "E")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/caveira.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "F")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/faca.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "G")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/garrafa.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "P")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/pistola.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "T")
                {
                    casaTabuleiro[i].BackgroundImage = Image.FromFile(@"../../img/tricornio.png");
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "Prisão")
                {
                    casaTabuleiro[i].BackColor = Color.Black;
                }
                else if (partidaAtiva.tabuleiro.Posicoes[i].Tipo == "Barco")
                {
                    casaTabuleiro[i].BackColor = Color.Black;
                }

                if (row == 6)
                {
                    if (!inverteRow)
                    {
                        inverteRow = true;
                        positionX = pcbEixoX + 300;
                    }
                    else
                    {
                        inverteRow = false;
                        positionX = pcbEixoX;
                    }
                    positionY = positionY + 60;
                    row = 0;
                }

                if (row < 6 && !inverteRow)
                {
                    casaTabuleiro[i].Location = new Point(positionX, positionY);
                    if (row < 6)
                    {
                        positionX = positionX + 60;
                    }
                    row++;
                }
                else if (row < 6 && inverteRow)
                {
                    casaTabuleiro[i].Location = new Point(positionX, positionY);
                    if (row < 6)
                    {
                        positionX = positionX - 60;
                    }
                    row++;
                }

                casaTabuleiro[i].Name = "casa" + i;
                casaTabuleiro[i].SizeMode = PictureBoxSizeMode.StretchImage;
                casaTabuleiro[i].Size = new Size(50, 50);
                casaTabuleiro[i].TabStop = false;
            }

            this.Controls.AddRange(casaTabuleiro);
        }


        private void btnPartidaIniciar_Click(object sender, EventArgs e)
        {
            // Verifica se o ID DO JOGADOR está vazio
            if (string.IsNullOrEmpty(txtJogadorID.Text))
                {

                MessageBox.Show("Campo 'ID do jogador' sem preenchimento!");
                return;

            }

            // Verifica se a SENHA DO JOGADOR está vazia
            if (string.IsNullOrEmpty(txtJogadorSenha.Text))
            {

                MessageBox.Show("Campo 'Senha do jogador' sem preenchimento!");
                return;

            }

            // Chamar o método IniciarPartida para iniciar a partida com o jogador
            LidarErros(Jogo.IniciarPartida(Convert.ToInt32(txtJogadorID.Text), txtJogadorSenha.Text));

            // Exibir mensagem informando que a partida foi iniciada
            MessageBox.Show("Partida iniciada!");
        }

        private void btnPartidaEntrar_Click(object sender, EventArgs e)
        {
            //Verifica se o campo ID PARTIDA está vázio
            if (string.IsNullOrEmpty(txtPartidaID.Text))
            {
                MessageBox.Show("Campo 'Partida id' sem preenchimento!");
                return;
            }

            //Verifica se o campo NOME DO JOGADOR está vázio
            if (string.IsNullOrEmpty(txtJogadorNome.Text))
            {
                MessageBox.Show("Campo 'Nome do jogador' sem preenchimento!");
                return;
            }

            //Verifica se o campo SENHA DA PARTIDA está vázio ou incorreto
            if (string.IsNullOrEmpty(txtPartidaSenha.Text))
            {
                MessageBox.Show("Senha da partida inválida ou sem preenchimento!");
                return;
            }

            // Chamar o método EntrarPartida para o jogador entrar na partida
            string entradaRetorno = Jogo.EntrarPartida(Convert.ToInt32(txtPartidaID.Text), txtJogadorNome.Text, txtPartidaSenha.Text);

            // Lidar com possíveis erros retornados pelo método EntrarPartida
            if (LidarErros(entradaRetorno))
            {
                // Separar as informações do jogador retornado pelo método
                string[] jogador = entradaRetorno.Split(',');

                // Exibir as informações do jogador nos campos de texto correspondentes
                txtJogadorID.Text = jogador[0].ToString();
                txtJogadorSenha.Text = jogador[1].ToString();
            }
        }
        private void btnPartidaCriar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de nome da partida está vazio
            if (string.IsNullOrEmpty(txtPartidaNome.Text))
            {
                MessageBox.Show("Campo 'Nome da partida' sem preenchimento!");
                return;
            }

            // Chamar o método CriarPartida para criar uma nova partida
            string partida = Jogo.CriarPartida(txtPartidaNome.Text, txtPartidaSenha.Text);

            // Lidar com possíveis erros retornados pelo método CriarPartida
            if (LidarErros(partida))
            {
                // Obter o ID da partida criada
                int partidaID = Convert.ToInt32(partida);

                // Exibir o ID da partida no campo de texto
                txtPartidaID.Text = partidaID.ToString();
            }
        }

        private void btnPartidaListar_Click(object sender, EventArgs e)
        {
            // Chamar o método ListarPartidas para obter a lista de partidas
            string lista = Jogo.ListarPartidas("T");

            // Separar as linhas da lista pelo caractere de quebra de linha "\n"
            string[] linha = lista.Split('\n');

            // Limpar a lista de mensagens
            lsbTudao.Items.Clear();

            // Adicionar cada partida na lista de mensagens
            for (int i = 0; i < linha.Length - 1; i++)
            {
                // Remover caracteres de quebra de linha "\r"
                linha[i] = linha[i].Replace("\r", "");

                // Exibir a partida na lista de mensagens
                lsbTudao.Items.Add(linha[i]);
            }
        }

        private void btnCartasListar_Click(object sender, EventArgs e)
        {
            // Obter o ID do jogador e senha informados nos campos de texto
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            // Chamar o método ConsultarMao para obter as cartas do jogador
            string cartas = Jogo.ConsultarMao(jogadorID, jogadorSenha);

            // Separar as cartas pelo caractere de quebra de linha "\n"
            string[] jogadorCartas = cartas.Split('\n');

            // Limpar a lista de mensagens
            lsbTudao.Items.Clear();

            // Adicionar cada carta na lista de mensagens
            for (int i = 0; i < jogadorCartas.Length - 1; i++)
            {
                // Remover caracteres de quebra de linha "\r"
                jogadorCartas[i].Replace("\r", "");

                // Exibir a carta na lista de mensagens
                lsbTudao.Items.Add(jogadorCartas[i]);
            }
        }



        private void btnJogadoresListar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de ID da partida está vazio
            if (string.IsNullOrEmpty(txtPartidaID.Text))
            {
                MessageBox.Show("Campo 'ID da partida' sem preenchimento!");
                return;
            }

            // Obter o ID da partida informado no campo de texto
            int partidaID = Convert.ToInt32(txtPartidaID.Text);

            // Chamar o método ListarJogadores para obter a lista de jogadores
            string retorno = Jogo.ListarJogadores(partidaID);

            // Lidar com possíveis erros retornados pelo método ListarJogadores
            if (LidarErros(retorno))
            {
                // Separar os jogadores pelo caractere de quebra de linha "\r"
                string[] jogadores = retorno.Split('\r');

                // Limpar a lista de mensagens
                lsbTudao.Items.Clear();

                // Adicionar cada jogador na lista de mensagens
                for (int i = 0; i < jogadores.Length - 1; i++)
                {
                    // Remover caracteres de quebra de linha "\r"
                    jogadores[i].Replace("\r", "");

                    // Exibir o jogador na lista de mensagens
                    lsbTudao.Items.Add(jogadores[i]);
                }
            }
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            // Obter o ID do jogador, senha, posição do pirata e carta selecionada nos campos de texto e combobox
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;
            int pirata = Convert.ToInt32(txtPirataPosicao.Text);
            string carta = cboCartas.SelectedItem.ToString();

            // Obter apenas a primeira letra da carta selecionada
            carta = carta.Substring(0, 1);

            // Limpar a lista de mensagens
            lsbTudao.Items.Clear();

            // Chamar o método Jogar para executar a jogada de andar
            string[] jogadas = Jogo.Jogar(jogadorID, jogadorSenha, pirata, carta).Split('\n');

            // Adicionar cada jogada na lista de mensagens
            foreach (string jogada in jogadas)
            {
                // Remover caracteres de quebra de linha "\r"
                string jogadaSemQuebraDeLinha = jogada.Replace("\r", "");

                // Exibir a jogada na lista de mensagens
                lsbTudao.Items.Add(jogadaSemQuebraDeLinha);
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Obter o ID do jogador, senha e posição do pirata informados nos campos de texto
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;
            int posicao = Convert.ToInt32(txtPirataPosicao.Text);

            // Chamar o método Jogar para executar a jogada de voltar
            string[] jogadas = Jogo.Jogar(jogadorID, jogadorSenha, posicao).Split('\n');

            // Adicionar cada jogada na lista de mensagens
            foreach (string jogada in jogadas)
            {
                // Remover caracteres de quebra de linha "\r"
                string jogadaSemQuebraDeLinha = jogada.Replace("\r", "");

                // Exibir a jogada na lista de mensagens
                lsbTudao.Items.Add(jogadaSemQuebraDeLinha);
            }
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            // Obter o ID do jogador e senha informados nos campos de texto
            int jogadorID = Convert.ToInt32(txtJogadorID.Text);
            string jogadorSenha = txtJogadorSenha.Text;

            // Chamar o método Jogar para executar a jogada de pular
            string resultado = Jogo.Jogar(jogadorID, jogadorSenha);

            // Lidar com possíveis erros retornados pelo método Jogar
            if (LidarErros(resultado))
            {
                // Exibir mensagem de jogada pulada na lista de mensagens
                lsbTudao.Items.Add("Jogada pulada!");
            }
            Console.WriteLine(resultado);
        }



        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de ID da partida está vazio
            if (string.IsNullOrEmpty(txtPartidaID.Text))
            {
                MessageBox.Show("Campo 'ID da partida' sem preenchimento!");
                return;
            }

            // Converter o ID da partida para inteiro
            int partidaID;
            if (!int.TryParse(txtPartidaID.Text, out partidaID))
            {
                MessageBox.Show("ID da partida inválido!");
                return;
            }

            // Chamar o método VerificarVez para obter as informações da vez atual
            string retorno = Jogo.VerificarVez(partidaID);

            // Verificar se ocorreu algum erro
            if (LidarErros(retorno))
            {
                // Separar as jogadas pelo caractere de quebra de linha "\r"
                string[] jogadas = retorno.Split('\r');

                // Limpar a lista de mensagens
                lsbTudao.Items.Clear();

                // Adicionar cada jogada na lista de mensagens
                for (int i = 0; i < jogadas.Length - 1; i++)
                {
                    // Remover caracteres de quebra de linha "\n"
                    jogadas[i] = jogadas[i].Replace("\n", "");

                    // Exibir a jogada na lista de mensagens
                    Console.WriteLine(jogadas[i]);
                    lsbTudao.Items.Add(jogadas[i]);
                }
            }
        }


        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            int partidaID;
            if (!int.TryParse(txtPartidaID.Text, out partidaID))
            {
                // Lidar com erro de conversão inválida
                return;
            }

            string dados = Jogo.VerificarVez(partidaID);
            string[] dadosVerificarVez = dados.Split('\n');
            string vez = dadosVerificarVez[0].Replace("\r", "");

            // Verifica se a partida começou
            if (vez == "Erro: Partida não está em andamento!") return;

            dadosVerificarVez = vez.Split(',');
            int idJogador = Convert.ToInt32(dadosVerificarVez[1]);

            // Verifica se a partida acabou
            if (dadosVerificarVez[0] == "E")
            {
                timerVerificarVez.Enabled = false;
                lsbTudao.Items.Clear();

                string nomeVencedor = verificarVencedor(dados);

                lsbTudao.Items.Add("Jogador Vencedor: " + nomeVencedor);
                return;
            }

            // Função para atualizar os dados em todas as jogadas
            partidaAtiva.AtualizarPosicoesDosPiratas(dados);
            // Desenha os piratas no tabuleiro
            partidaAtiva.Ronaizer.desenharPiratas(partidaAtiva.tabuleiro, casaTabuleiro);

            // Verifica se é nossa vez
            if (idJogador != partidaAtiva.Ronaizer.id)
            {
                lsbTudao.Items.Clear();
                foreach (Inimigo inimigo in partidaAtiva.inimigos)
                {
                    if (idJogador == inimigo.id)
                    {
                        lsbTudao.Items.Add("Vez de:" + inimigo.nome + "(" + inimigo.cor + ")\n");
                    }
                }
                return;
            }

            // Printando o tabuleiro
            Console.WriteLine(partidaAtiva.tabuleiro.ToString());
            // Printando todos os piratas da Kuriso
            Console.WriteLine(partidaAtiva.Ronaizer.ToString());
            // Printando todos os piratas dos inimigos
            if (partidaAtiva.inimigos.Count > 0)
            {
                foreach (Inimigo inimigo in partidaAtiva.inimigos)
                {
                    Console.WriteLine(inimigo.ToString());
                }
            }

            Jogar();
        }

        void Jogar()
        {
            // Limpar a lista de mensagens e exibir mensagem de vez do jogador
            lsbTudao.Items.Clear();
            lsbTudao.Items.Add("Nossa vez! (" + partidaAtiva.Ronaizer.cor + ")\n");

            // Reiniciar as contagens das cartas exibidas na interface
            lblChave.Text = "x0";
            lblEsq.Text = "x0";
            lblFaca.Text = "x0";
            lblGar.Text = "x0";
            lblPist.Text = "x0";
            lblTric.Text = "x0";

            // Variáveis para contar as ocorrências de cada carta
            int chave = 0, esqueleto = 0, faca = 0, garrafa = 0, pistola = 0, tricornio = 0;

            // Percorrer as cartas do jogador e atualizar as contagens e a exibição na interface
            foreach (string carta in partidaAtiva.Ronaizer.cartas)
            {
                if (carta == "C")
                {
                    chave++;
                    lblChave.Text = "x" + chave.ToString();
                }
                else if (carta == "E")
                {
                    esqueleto++;
                    lblEsq.Text = "x" + esqueleto.ToString();
                }
                else if (carta == "F")
                {
                    faca++;
                    lblFaca.Text = "x" + faca.ToString();
                }
                else if (carta == "G")
                {
                    garrafa++;
                    lblGar.Text = "x" + garrafa.ToString();
                }
                else if (carta == "P")
                {
                    pistola++;
                    lblPist.Text = "x" + pistola.ToString();
                }
                else if (carta == "T")
                {
                    tricornio++;
                    lblTric.Text = "x" + tricornio.ToString();
                }
            }

            // Avaliar e realizar a jogada com base nas consequências
            Jogada jogada = partidaAtiva.Ronaizer.AvaliarMelhorJogada(partidaAtiva.tabuleiro);

            if (jogada.Carta == "pular")
            {
                partidaAtiva.Ronaizer.pularJogada();
            }
            else if (jogada.Carta == "voltar")
            {
                partidaAtiva.Ronaizer.voltarPirata(jogada);
            }
            else
            {
                partidaAtiva.Ronaizer.jogar(jogada);
            }

            // Atualizar as cartas do jogador
            partidaAtiva.Ronaizer.atualizarCartas();
        }

        public static bool LidarErros(string erro)
        {
            // Verificar se a mensagem de erro não contém "ERRO:" ou "Erro:"
            if (!erro.Contains("ERRO:") && !erro.Contains("Erro:"))
            {
                return true; // Não é um erro relevante
            }

            // Exibir mensagem de erro em uma caixa de diálogo
            MessageBox.Show(erro);
            return false; // É um erro relevante
        }


        public string verificarVencedor(string vez)
        {
            string vencedor = "";
            string[] posicoes, jogadas;
            jogadas = vez.Split('\n');

            for (int i = 1; i < (jogadas.Length - 1); i++)
            {

                jogadas[i] = jogadas[i].Replace("\r", "");
                posicoes = jogadas[i].Split(',');

                int posicao = Convert.ToInt16(posicoes[0]),
                    idJogador = Convert.ToInt16(posicoes[1]),
                    numeroPiratas = Convert.ToInt16(posicoes[2]);

                if (posicao == 37 && numeroPiratas == 6)
                {
                    if (idJogador == partidaAtiva.Ronaizer.id)
                    {
                        vencedor = partidaAtiva.Ronaizer.nome;
                        break;
                    }
                    foreach (Inimigo inimigo in partidaAtiva.inimigos)
                    {

                        if (idJogador == inimigo.id)
                        {
                            vencedor = inimigo.nome;
                            break;
                        }

                    }
                }

            }

            return vencedor;

        }



        private void timerAtualizaInterface_Tick(object sender, EventArgs e)
        {
            // Limpar e atualizar a interface do tabuleiro

            // Percorrer todas as casas do tabuleiro
            for (int i = 1; i < 37; i++)
            {
                casaTabuleiro[i].Invalidate(); // Invalidar a casa para forçar o redesenho
            }
        }


        private void btnRonaizer_Click(object sender, EventArgs e)
        {
            // Exibir mensagem de início do Ronaizer
            Console.WriteLine("\nRonaizer iniciada.\n");

            // Inicializar todas as variáveis aqui
            int partidaID = Convert.ToInt32(txtPartidaID.Text); // ID da partida obtido do campo de texto
            string partidaNome = txtPartidaNome.Text; // Nome da partida obtido do campo de texto
            string partidaSenha = txtPartidaSenha.Text; // Senha da partida obtida do campo de texto
            int jogadorID = Convert.ToInt32(txtJogadorID.Text); // ID do jogador obtido do campo de texto
            string jogadorNome = txtJogadorNome.Text; // Nome do jogador obtido do campo de texto
            string jogadorSenha = txtJogadorSenha.Text; // Senha do jogador obtida do campo de texto

            // Criar uma nova instância da classe Partida com os valores obtidos
            partidaAtiva = new Partida(partidaID, partidaNome, partidaSenha, jogadorID, jogadorNome, jogadorSenha);


            // Ativar o timer para verificar a vez do jogador
            timerVerificarVez.Enabled = true;

 

            // Ativar o timer para atualizar a interface
            timerAtulizaInterface.Enabled = true;
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            // Inicializar todas as variáveis aqui
            int partidaID = Convert.ToInt32(txtPartidaID.Text); // ID da partida obtido do campo de texto
            string partidaNome = txtPartidaNome.Text; // Nome da partida obtido do campo de texto
            string partidaSenha = txtPartidaSenha.Text; // Senha da partida obtida do campo de texto
            int jogadorID = Convert.ToInt32(txtJogadorID.Text); // ID do jogador obtido do campo de texto
            string jogadorNome = txtJogadorNome.Text; // Nome do jogador obtido do campo de texto
            string jogadorSenha = txtJogadorSenha.Text; // Senha do jogador obtida do campo de texto

            // Criar uma nova instância da classe Partida com os valores obtidos
            partidaAtiva = new Partida(partidaID, partidaNome, partidaSenha, jogadorID, jogadorNome, jogadorSenha);




            // Criar a interface do tabuleiro
            criarInterfaceTabuleiro();
        }
    }
}

