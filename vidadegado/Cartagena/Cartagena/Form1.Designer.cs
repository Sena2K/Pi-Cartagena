namespace Cartagena
{
    partial class Cartagena
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartagena));
            this.txtJogadorID = new System.Windows.Forms.TextBox();
            this.txtJogadorSenha = new System.Windows.Forms.TextBox();
            this.lblIDJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.btnPartidaIniciar = new System.Windows.Forms.Button();
            this.txtPartidaID = new System.Windows.Forms.TextBox();
            this.txtPartidaSenha = new System.Windows.Forms.TextBox();
            this.lblPartidaID = new System.Windows.Forms.Label();
            this.lblPartidaSenha = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblPartidaNome = new System.Windows.Forms.Label();
            this.txtPartidaNome = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnPartidaListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogadoresListar = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.cboCartas = new System.Windows.Forms.ComboBox();
            this.txtPirataPosicao = new System.Windows.Forms.TextBox();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timerVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.timerAtulizaInterface = new System.Windows.Forms.Timer(this.components);
            this.Chave = new System.Windows.Forms.PictureBox();
            this.Caveira = new System.Windows.Forms.PictureBox();
            this.Faca = new System.Windows.Forms.PictureBox();
            this.Garrafa = new System.Windows.Forms.PictureBox();
            this.Pistola = new System.Windows.Forms.PictureBox();
            this.Tricornio = new System.Windows.Forms.PictureBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblEsq = new System.Windows.Forms.Label();
            this.lblFaca = new System.Windows.Forms.Label();
            this.lblGar = new System.Windows.Forms.Label();
            this.lblPist = new System.Windows.Forms.Label();
            this.lblTric = new System.Windows.Forms.Label();
            this.lsbTudao = new System.Windows.Forms.ListBox();
            this.btnRonaizer = new System.Windows.Forms.Button();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.btnTabuleiro = new System.Windows.Forms.Button();
            this.lblMedelin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caveira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garrafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tricornio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJogadorID
            // 
            this.txtJogadorID.Location = new System.Drawing.Point(22, 332);
            this.txtJogadorID.Name = "txtJogadorID";
            this.txtJogadorID.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorID.TabIndex = 0;
            // 
            // txtJogadorSenha
            // 
            this.txtJogadorSenha.Location = new System.Drawing.Point(24, 374);
            this.txtJogadorSenha.Name = "txtJogadorSenha";
            this.txtJogadorSenha.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorSenha.TabIndex = 1;
            // 
            // lblIDJogador
            // 
            this.lblIDJogador.AutoSize = true;
            this.lblIDJogador.Location = new System.Drawing.Point(24, 314);
            this.lblIDJogador.Name = "lblIDJogador";
            this.lblIDJogador.Size = new System.Drawing.Size(71, 13);
            this.lblIDJogador.TabIndex = 2;
            this.lblIDJogador.Text = "ID do jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(23, 357);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(91, 13);
            this.lblSenhaJogador.TabIndex = 3;
            this.lblSenhaJogador.Text = "Senha do jogador";
            // 
            // btnPartidaIniciar
            // 
            this.btnPartidaIniciar.Location = new System.Drawing.Point(201, 348);
            this.btnPartidaIniciar.Name = "btnPartidaIniciar";
            this.btnPartidaIniciar.Size = new System.Drawing.Size(79, 32);
            this.btnPartidaIniciar.TabIndex = 4;
            this.btnPartidaIniciar.Text = "Iniciar Partida";
            this.btnPartidaIniciar.UseVisualStyleBackColor = true;
            this.btnPartidaIniciar.Click += new System.EventHandler(this.btnPartidaIniciar_Click);
            // 
            // txtPartidaID
            // 
            this.txtPartidaID.Location = new System.Drawing.Point(28, 100);
            this.txtPartidaID.Name = "txtPartidaID";
            this.txtPartidaID.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaID.TabIndex = 5;
            // 
            // txtPartidaSenha
            // 
            this.txtPartidaSenha.Location = new System.Drawing.Point(28, 141);
            this.txtPartidaSenha.Name = "txtPartidaSenha";
            this.txtPartidaSenha.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaSenha.TabIndex = 6;
            this.txtPartidaSenha.UseSystemPasswordChar = true;
            // 
            // lblPartidaID
            // 
            this.lblPartidaID.AutoSize = true;
            this.lblPartidaID.Location = new System.Drawing.Point(29, 83);
            this.lblPartidaID.Name = "lblPartidaID";
            this.lblPartidaID.Size = new System.Drawing.Size(68, 13);
            this.lblPartidaID.TabIndex = 7;
            this.lblPartidaID.Text = "ID da partida";
            // 
            // lblPartidaSenha
            // 
            this.lblPartidaSenha.AutoSize = true;
            this.lblPartidaSenha.Location = new System.Drawing.Point(28, 124);
            this.lblPartidaSenha.Name = "lblPartidaSenha";
            this.lblPartidaSenha.Size = new System.Drawing.Size(88, 13);
            this.lblPartidaSenha.TabIndex = 8;
            this.lblPartidaSenha.Text = "Senha da partida";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(182, 296);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(122, 32);
            this.btnEntrarPartida.TabIndex = 9;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnPartidaEntrar_Click);
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(23, 290);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(134, 20);
            this.txtJogadorNome.TabIndex = 10;
            // 
            // lblJogadorNome
            // 
            this.lblJogadorNome.AutoSize = true;
            this.lblJogadorNome.Location = new System.Drawing.Point(23, 271);
            this.lblJogadorNome.Name = "lblJogadorNome";
            this.lblJogadorNome.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorNome.TabIndex = 11;
            this.lblJogadorNome.Text = "Nome do Jogador";
            // 
            // lblPartidaNome
            // 
            this.lblPartidaNome.AutoSize = true;
            this.lblPartidaNome.Location = new System.Drawing.Point(29, 41);
            this.lblPartidaNome.Name = "lblPartidaNome";
            this.lblPartidaNome.Size = new System.Drawing.Size(85, 13);
            this.lblPartidaNome.TabIndex = 13;
            this.lblPartidaNome.Text = "Nome da partida";
            // 
            // txtPartidaNome
            // 
            this.txtPartidaNome.Location = new System.Drawing.Point(28, 59);
            this.txtPartidaNome.Name = "txtPartidaNome";
            this.txtPartidaNome.Size = new System.Drawing.Size(134, 20);
            this.txtPartidaNome.TabIndex = 12;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(60, 168);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(79, 32);
            this.btnCriarPartida.TabIndex = 14;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnPartidaCriar_Click);
            // 
            // btnPartidaListar
            // 
            this.btnPartidaListar.Location = new System.Drawing.Point(24, 414);
            this.btnPartidaListar.Name = "btnPartidaListar";
            this.btnPartidaListar.Size = new System.Drawing.Size(181, 32);
            this.btnPartidaListar.TabIndex = 15;
            this.btnPartidaListar.Text = "Listar Partidas";
            this.btnPartidaListar.UseVisualStyleBackColor = true;
            this.btnPartidaListar.Click += new System.EventHandler(this.btnPartidaListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // btnJogadoresListar
            // 
            this.btnJogadoresListar.Location = new System.Drawing.Point(210, 414);
            this.btnJogadoresListar.Name = "btnJogadoresListar";
            this.btnJogadoresListar.Size = new System.Drawing.Size(107, 32);
            this.btnJogadoresListar.TabIndex = 19;
            this.btnJogadoresListar.Text = "Listar Jogadores";
            this.btnJogadoresListar.UseVisualStyleBackColor = true;
            this.btnJogadoresListar.Click += new System.EventHandler(this.btnJogadoresListar_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(22, 653);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(54, 39);
            this.btnAndar.TabIndex = 20;
            this.btnAndar.Text = "Jogar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // cboCartas
            // 
            this.cboCartas.FormattingEnabled = true;
            this.cboCartas.Items.AddRange(new object[] {
            "",
            "Chave",
            "Esqueleto",
            "Faca",
            "Garrafa",
            "Pistola",
            "Tricórnio"});
            this.cboCartas.Location = new System.Drawing.Point(178, 572);
            this.cboCartas.Name = "cboCartas";
            this.cboCartas.Size = new System.Drawing.Size(134, 21);
            this.cboCartas.TabIndex = 21;
            // 
            // txtPirataPosicao
            // 
            this.txtPirataPosicao.Location = new System.Drawing.Point(22, 573);
            this.txtPirataPosicao.Name = "txtPirataPosicao";
            this.txtPirataPosicao.Size = new System.Drawing.Size(134, 20);
            this.txtPirataPosicao.TabIndex = 24;
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(20, 613);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(134, 31);
            this.btnPular.TabIndex = 32;
            this.btnPular.Text = "Pular Jogada";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(82, 653);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(74, 39);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Mover para trás";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // timerVerificarVez
            // 
            this.timerVerificarVez.Interval = 1500;
            this.timerVerificarVez.Tick += new System.EventHandler(this.timerVerificarVez_Tick);
            // 
            // timerAtulizaInterface
            // 
            this.timerAtulizaInterface.Interval = 2000;
            this.timerAtulizaInterface.Tick += new System.EventHandler(this.timerAtualizaInterface_Tick);
            // 
            // Chave
            // 
            this.Chave.ErrorImage = null;
            this.Chave.Image = ((System.Drawing.Image)(resources.GetObject("Chave.Image")));
            this.Chave.InitialImage = null;
            this.Chave.Location = new System.Drawing.Point(409, 573);
            this.Chave.Name = "Chave";
            this.Chave.Size = new System.Drawing.Size(50, 50);
            this.Chave.TabIndex = 41;
            this.Chave.TabStop = false;
            // 
            // Caveira
            // 
            this.Caveira.ErrorImage = null;
            this.Caveira.Image = ((System.Drawing.Image)(resources.GetObject("Caveira.Image")));
            this.Caveira.InitialImage = null;
            this.Caveira.Location = new System.Drawing.Point(504, 573);
            this.Caveira.Name = "Caveira";
            this.Caveira.Size = new System.Drawing.Size(50, 50);
            this.Caveira.TabIndex = 42;
            this.Caveira.TabStop = false;
            // 
            // Faca
            // 
            this.Faca.ErrorImage = null;
            this.Faca.Image = ((System.Drawing.Image)(resources.GetObject("Faca.Image")));
            this.Faca.InitialImage = null;
            this.Faca.Location = new System.Drawing.Point(599, 573);
            this.Faca.Name = "Faca";
            this.Faca.Size = new System.Drawing.Size(50, 50);
            this.Faca.TabIndex = 43;
            this.Faca.TabStop = false;
            // 
            // Garrafa
            // 
            this.Garrafa.ErrorImage = null;
            this.Garrafa.Image = ((System.Drawing.Image)(resources.GetObject("Garrafa.Image")));
            this.Garrafa.InitialImage = null;
            this.Garrafa.Location = new System.Drawing.Point(679, 573);
            this.Garrafa.Name = "Garrafa";
            this.Garrafa.Size = new System.Drawing.Size(50, 50);
            this.Garrafa.TabIndex = 44;
            this.Garrafa.TabStop = false;
            // 
            // Pistola
            // 
            this.Pistola.ErrorImage = null;
            this.Pistola.Image = ((System.Drawing.Image)(resources.GetObject("Pistola.Image")));
            this.Pistola.InitialImage = null;
            this.Pistola.Location = new System.Drawing.Point(775, 573);
            this.Pistola.Name = "Pistola";
            this.Pistola.Size = new System.Drawing.Size(50, 50);
            this.Pistola.TabIndex = 45;
            this.Pistola.TabStop = false;
            // 
            // Tricornio
            // 
            this.Tricornio.ErrorImage = null;
            this.Tricornio.Image = ((System.Drawing.Image)(resources.GetObject("Tricornio.Image")));
            this.Tricornio.InitialImage = null;
            this.Tricornio.Location = new System.Drawing.Point(877, 573);
            this.Tricornio.Name = "Tricornio";
            this.Tricornio.Size = new System.Drawing.Size(50, 50);
            this.Tricornio.TabIndex = 46;
            this.Tricornio.TabStop = false;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(465, 592);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(18, 13);
            this.lblChave.TabIndex = 47;
            this.lblChave.Text = "x0";
            // 
            // lblEsq
            // 
            this.lblEsq.AutoSize = true;
            this.lblEsq.Location = new System.Drawing.Point(560, 591);
            this.lblEsq.Name = "lblEsq";
            this.lblEsq.Size = new System.Drawing.Size(18, 13);
            this.lblEsq.TabIndex = 48;
            this.lblEsq.Text = "x0";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.Location = new System.Drawing.Point(655, 591);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(18, 13);
            this.lblFaca.TabIndex = 49;
            this.lblFaca.Text = "x0";
            // 
            // lblGar
            // 
            this.lblGar.AutoSize = true;
            this.lblGar.Location = new System.Drawing.Point(735, 593);
            this.lblGar.Name = "lblGar";
            this.lblGar.Size = new System.Drawing.Size(18, 13);
            this.lblGar.TabIndex = 50;
            this.lblGar.Text = "x0";
            // 
            // lblPist
            // 
            this.lblPist.AutoSize = true;
            this.lblPist.Location = new System.Drawing.Point(831, 590);
            this.lblPist.Name = "lblPist";
            this.lblPist.Size = new System.Drawing.Size(18, 13);
            this.lblPist.TabIndex = 51;
            this.lblPist.Text = "x0";
            // 
            // lblTric
            // 
            this.lblTric.AutoSize = true;
            this.lblTric.Location = new System.Drawing.Point(933, 592);
            this.lblTric.Name = "lblTric";
            this.lblTric.Size = new System.Drawing.Size(18, 13);
            this.lblTric.TabIndex = 52;
            this.lblTric.Text = "x0";
            // 
            // lsbTudao
            // 
            this.lsbTudao.FormattingEnabled = true;
            this.lsbTudao.Location = new System.Drawing.Point(504, 414);
            this.lsbTudao.Name = "lsbTudao";
            this.lsbTudao.Size = new System.Drawing.Size(419, 121);
            this.lsbTudao.TabIndex = 53;
            // 
            // btnRonaizer
            // 
            this.btnRonaizer.Location = new System.Drawing.Point(22, 506);
            this.btnRonaizer.Name = "btnRonaizer";
            this.btnRonaizer.Size = new System.Drawing.Size(292, 30);
            this.btnRonaizer.TabIndex = 54;
            this.btnRonaizer.Text = "Ronaizer (iniciar bot)";
            this.btnRonaizer.UseVisualStyleBackColor = true;
            this.btnRonaizer.Click += new System.EventHandler(this.btnRonaizer_Click);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.BackColor = System.Drawing.Color.GhostWhite;
            this.lblCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCriarPartida.Location = new System.Drawing.Point(12, 9);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(177, 25);
            this.lblCriarPartida.TabIndex = 55;
            this.lblCriarPartida.Text = "Criar uma partida";
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.BackColor = System.Drawing.Color.GhostWhite;
            this.lblEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblEntrarPartida.Location = new System.Drawing.Point(23, 221);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(224, 25);
            this.lblEntrarPartida.TabIndex = 56;
            this.lblEntrarPartida.Text = "Entrar em uma partida";
            // 
            // btnTabuleiro
            // 
            this.btnTabuleiro.Location = new System.Drawing.Point(23, 461);
            this.btnTabuleiro.Name = "btnTabuleiro";
            this.btnTabuleiro.Size = new System.Drawing.Size(292, 30);
            this.btnTabuleiro.TabIndex = 57;
            this.btnTabuleiro.Text = "Mostrar Tabuleiro";
            this.btnTabuleiro.UseVisualStyleBackColor = true;
            this.btnTabuleiro.Click += new System.EventHandler(this.btnTabuleiro_Click);
            // 
            // lblMedelin
            // 
            this.lblMedelin.AutoSize = true;
            this.lblMedelin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedelin.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedelin.ForeColor = System.Drawing.Color.Maroon;
            this.lblMedelin.Location = new System.Drawing.Point(195, 20);
            this.lblMedelin.Name = "lblMedelin";
            this.lblMedelin.Size = new System.Drawing.Size(324, 106);
            this.lblMedelin.TabIndex = 58;
            this.lblMedelin.Text = "Medelin";
            // 
            // Cartagena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 730);
            this.Controls.Add(this.lblMedelin);
            this.Controls.Add(this.btnTabuleiro);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.btnRonaizer);
            this.Controls.Add(this.lsbTudao);
            this.Controls.Add(this.lblTric);
            this.Controls.Add(this.lblPist);
            this.Controls.Add(this.lblGar);
            this.Controls.Add(this.lblFaca);
            this.Controls.Add(this.lblEsq);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.Tricornio);
            this.Controls.Add(this.Pistola);
            this.Controls.Add(this.Garrafa);
            this.Controls.Add(this.Faca);
            this.Controls.Add(this.Caveira);
            this.Controls.Add(this.Chave);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.txtPirataPosicao);
            this.Controls.Add(this.cboCartas);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnJogadoresListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPartidaListar);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblPartidaNome);
            this.Controls.Add(this.txtPartidaNome);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.txtJogadorNome);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblPartidaSenha);
            this.Controls.Add(this.lblPartidaID);
            this.Controls.Add(this.txtPartidaSenha);
            this.Controls.Add(this.txtPartidaID);
            this.Controls.Add(this.btnPartidaIniciar);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIDJogador);
            this.Controls.Add(this.txtJogadorSenha);
            this.Controls.Add(this.txtJogadorID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cartagena";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ronaizer";
            this.TransparencyKey = System.Drawing.Color.DarkViolet;
            ((System.ComponentModel.ISupportInitialize)(this.Chave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caveira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Garrafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tricornio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJogadorID;
        private System.Windows.Forms.TextBox txtJogadorSenha;
        private System.Windows.Forms.Label lblIDJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Button btnPartidaIniciar;
        private System.Windows.Forms.TextBox txtPartidaID;
        private System.Windows.Forms.TextBox txtPartidaSenha;
        private System.Windows.Forms.Label lblPartidaID;
        private System.Windows.Forms.Label lblPartidaSenha;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblPartidaNome;
        private System.Windows.Forms.TextBox txtPartidaNome;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnPartidaListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogadoresListar;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.ComboBox cboCartas;
        private System.Windows.Forms.TextBox txtPirataPosicao;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timerVerificarVez;
        private System.Windows.Forms.Timer timerAtulizaInterface;
        private System.Windows.Forms.PictureBox Chave;
        private System.Windows.Forms.PictureBox Caveira;
        private System.Windows.Forms.PictureBox Faca;
        private System.Windows.Forms.PictureBox Garrafa;
        private System.Windows.Forms.PictureBox Pistola;
        private System.Windows.Forms.PictureBox Tricornio;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblEsq;
        private System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.Label lblGar;
        private System.Windows.Forms.Label lblPist;
        private System.Windows.Forms.Label lblTric;
        private System.Windows.Forms.ListBox lsbTudao;
        private System.Windows.Forms.Button btnRonaizer;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Button btnTabuleiro;
        private System.Windows.Forms.Label lblMedelin;
    }
}

