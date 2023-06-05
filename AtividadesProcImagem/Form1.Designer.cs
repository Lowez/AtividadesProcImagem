namespace AtividadesProcImagem
{
    partial class brightnessLabel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load1 = new System.Windows.Forms.Button();
            this.load2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.multiplicacaoInput = new System.Windows.Forms.TextBox();
            this.divisaoInput = new System.Windows.Forms.TextBox();
            this.rgbToGrey = new System.Windows.Forms.Button();
            this.btRBGto8bits = new System.Windows.Forms.Button();
            this.blending = new System.Windows.Forms.Button();
            this.blendingFactor = new System.Windows.Forms.TextBox();
            this.btNOT = new System.Windows.Forms.Button();
            this.btXOR = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btAND = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.histogramaOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bright = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.brightLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMelhorias = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btAplicarMelhoria = new System.Windows.Forms.Button();
            this.btAplicarFiltros = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFiltros = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.histogramaEqualizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btToDouble = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.filtragemGaus = new System.Windows.Forms.GroupBox();
            this.pictureBoxKernel = new System.Windows.Forms.PictureBox();
            this.txSigmaValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaEqualizado)).BeginInit();
            this.filtragemGaus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKernel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(38, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // load1
            // 
            this.load1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.load1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load1.ForeColor = System.Drawing.Color.Black;
            this.load1.Location = new System.Drawing.Point(78, 305);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(122, 42);
            this.load1.TabIndex = 2;
            this.load1.Text = "Carregar Imagem 1";
            this.load1.UseVisualStyleBackColor = false;
            this.load1.Click += new System.EventHandler(this.load1_Click_1);
            // 
            // load2
            // 
            this.load2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.load2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load2.Location = new System.Drawing.Point(333, 305);
            this.load2.Name = "load2";
            this.load2.Size = new System.Drawing.Size(122, 42);
            this.load2.TabIndex = 4;
            this.load2.Text = "Carregar Imagem 2";
            this.load2.UseVisualStyleBackColor = false;
            this.load2.Click += new System.EventHandler(this.load2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(293, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Computação\\Downloads\\MaterialMatlab\\Matlab";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // adicao
            // 
            this.adicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adicao.Location = new System.Drawing.Point(580, 92);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(50, 45);
            this.adicao.TabIndex = 5;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = false;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtracao.Location = new System.Drawing.Point(580, 159);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(50, 45);
            this.subtracao.TabIndex = 6;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = false;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicacao.Location = new System.Drawing.Point(580, 228);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(50, 45);
            this.multiplicacao.TabIndex = 7;
            this.multiplicacao.Text = "*";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.divisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divisao.Location = new System.Drawing.Point(580, 290);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(50, 45);
            this.divisao.TabIndex = 8;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(863, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(868, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imagem 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(302, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Imagem 2";
            // 
            // multiplicacaoInput
            // 
            this.multiplicacaoInput.Location = new System.Drawing.Point(647, 241);
            this.multiplicacaoInput.Name = "multiplicacaoInput";
            this.multiplicacaoInput.Size = new System.Drawing.Size(43, 20);
            this.multiplicacaoInput.TabIndex = 13;
            this.multiplicacaoInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.multiplicacaoInput_KeyUp);
            // 
            // divisaoInput
            // 
            this.divisaoInput.Location = new System.Drawing.Point(647, 303);
            this.divisaoInput.Name = "divisaoInput";
            this.divisaoInput.Size = new System.Drawing.Size(43, 20);
            this.divisaoInput.TabIndex = 14;
            this.divisaoInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.divisaoInput_KeyUp);
            // 
            // rgbToGrey
            // 
            this.rgbToGrey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rgbToGrey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgbToGrey.ForeColor = System.Drawing.Color.Black;
            this.rgbToGrey.Location = new System.Drawing.Point(38, 384);
            this.rgbToGrey.Name = "rgbToGrey";
            this.rgbToGrey.Size = new System.Drawing.Size(129, 30);
            this.rgbToGrey.TabIndex = 15;
            this.rgbToGrey.Text = "RGB -> 1bit";
            this.rgbToGrey.UseVisualStyleBackColor = false;
            this.rgbToGrey.Click += new System.EventHandler(this.rgbToGrey_Click);
            // 
            // btRBGto8bits
            // 
            this.btRBGto8bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btRBGto8bits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRBGto8bits.ForeColor = System.Drawing.Color.Black;
            this.btRBGto8bits.Location = new System.Drawing.Point(38, 435);
            this.btRBGto8bits.Name = "btRBGto8bits";
            this.btRBGto8bits.Size = new System.Drawing.Size(128, 30);
            this.btRBGto8bits.TabIndex = 16;
            this.btRBGto8bits.Text = "RGB -> 8bit";
            this.btRBGto8bits.UseVisualStyleBackColor = false;
            this.btRBGto8bits.Click += new System.EventHandler(this.btRBGto8bits_Click);
            // 
            // blending
            // 
            this.blending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.blending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blending.ForeColor = System.Drawing.Color.Black;
            this.blending.Location = new System.Drawing.Point(182, 384);
            this.blending.Name = "blending";
            this.blending.Size = new System.Drawing.Size(126, 30);
            this.blending.TabIndex = 17;
            this.blending.Text = "Blending";
            this.blending.UseVisualStyleBackColor = false;
            this.blending.Click += new System.EventHandler(this.blending_Click);
            // 
            // blendingFactor
            // 
            this.blendingFactor.Location = new System.Drawing.Point(315, 390);
            this.blendingFactor.Name = "blendingFactor";
            this.blendingFactor.Size = new System.Drawing.Size(43, 20);
            this.blendingFactor.TabIndex = 18;
            // 
            // btNOT
            // 
            this.btNOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btNOT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNOT.Location = new System.Drawing.Point(731, 290);
            this.btNOT.Name = "btNOT";
            this.btNOT.Size = new System.Drawing.Size(50, 45);
            this.btNOT.TabIndex = 22;
            this.btNOT.Text = "NOT";
            this.btNOT.UseVisualStyleBackColor = false;
            this.btNOT.Click += new System.EventHandler(this.btNOT_Click);
            // 
            // btXOR
            // 
            this.btXOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btXOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXOR.Location = new System.Drawing.Point(731, 228);
            this.btXOR.Name = "btXOR";
            this.btXOR.Size = new System.Drawing.Size(50, 45);
            this.btXOR.TabIndex = 21;
            this.btXOR.Text = "XOR";
            this.btXOR.UseVisualStyleBackColor = false;
            this.btXOR.Click += new System.EventHandler(this.btXOR_Click);
            // 
            // btOR
            // 
            this.btOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOR.Location = new System.Drawing.Point(731, 159);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(50, 45);
            this.btOR.TabIndex = 20;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = false;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btAND
            // 
            this.btAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAND.Location = new System.Drawing.Point(731, 92);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(50, 45);
            this.btAND.TabIndex = 19;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = false;
            this.btAND.Click += new System.EventHandler(this.btAND_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(577, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aritméticos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(728, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lógicos";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Location = new System.Drawing.Point(903, 305);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 42);
            this.save.TabIndex = 25;
            this.save.Text = "Salvar Resultado";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // histogramaOriginal
            // 
            chartArea4.Name = "ChartArea1";
            this.histogramaOriginal.ChartAreas.Add(chartArea4);
            this.histogramaOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend4.Name = "Legend1";
            this.histogramaOriginal.Legends.Add(legend4);
            this.histogramaOriginal.Location = new System.Drawing.Point(38, 554);
            this.histogramaOriginal.Name = "histogramaOriginal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.histogramaOriginal.Series.Add(series4);
            this.histogramaOriginal.Size = new System.Drawing.Size(459, 251);
            this.histogramaOriginal.TabIndex = 28;
            this.histogramaOriginal.Text = "chart1";
            // 
            // bright
            // 
            this.bright.LargeChange = 1;
            this.bright.Location = new System.Drawing.Point(571, 386);
            this.bright.Maximum = 25;
            this.bright.Name = "bright";
            this.bright.Size = new System.Drawing.Size(219, 45);
            this.bright.TabIndex = 29;
            this.bright.ValueChanged += new System.EventHandler(this.bright_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(576, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Modificador de Brilho:";
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.brightLabel.Location = new System.Drawing.Point(743, 366);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(16, 17);
            this.brightLabel.TabIndex = 31;
            this.brightLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(577, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(765, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(48, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Histograma Original";
            // 
            // cbMelhorias
            // 
            this.cbMelhorias.FormattingEnabled = true;
            this.cbMelhorias.Items.AddRange(new object[] {
            "Negativo",
            "Equalização de Histograma"});
            this.cbMelhorias.Location = new System.Drawing.Point(580, 556);
            this.cbMelhorias.Name = "cbMelhorias";
            this.cbMelhorias.Size = new System.Drawing.Size(141, 21);
            this.cbMelhorias.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(576, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Melhorias de Imagem:";
            // 
            // btAplicarMelhoria
            // 
            this.btAplicarMelhoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAplicarMelhoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAplicarMelhoria.Location = new System.Drawing.Point(727, 556);
            this.btAplicarMelhoria.Name = "btAplicarMelhoria";
            this.btAplicarMelhoria.Size = new System.Drawing.Size(54, 21);
            this.btAplicarMelhoria.TabIndex = 37;
            this.btAplicarMelhoria.Text = "Aplicar";
            this.btAplicarMelhoria.UseVisualStyleBackColor = false;
            this.btAplicarMelhoria.Click += new System.EventHandler(this.btAplicarMelhoria_Click);
            // 
            // btAplicarFiltros
            // 
            this.btAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAplicarFiltros.Location = new System.Drawing.Point(727, 649);
            this.btAplicarFiltros.Name = "btAplicarFiltros";
            this.btAplicarFiltros.Size = new System.Drawing.Size(54, 21);
            this.btAplicarFiltros.TabIndex = 40;
            this.btAplicarFiltros.Text = "Aplicar";
            this.btAplicarFiltros.UseVisualStyleBackColor = false;
            this.btAplicarFiltros.Click += new System.EventHandler(this.btAplicarFiltros_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(576, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Filtros(3x3):";
            // 
            // cbFiltros
            // 
            this.cbFiltros.FormattingEnabled = true;
            this.cbFiltros.Items.AddRange(new object[] {
            "Min",
            "Max",
            "Mean(Media)",
            "Mediana",
            "Ordem",
            "Suavização Conservativa",
            "Gaussiana"});
            this.cbFiltros.Location = new System.Drawing.Point(580, 649);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Size = new System.Drawing.Size(141, 21);
            this.cbFiltros.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(873, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 29);
            this.label12.TabIndex = 42;
            this.label12.Text = "Histograma Equalizado";
            // 
            // histogramaEqualizado
            // 
            chartArea3.Name = "ChartArea1";
            this.histogramaEqualizado.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.histogramaEqualizado.Legends.Add(legend3);
            this.histogramaEqualizado.Location = new System.Drawing.Point(863, 554);
            this.histogramaEqualizado.Name = "histogramaEqualizado";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.histogramaEqualizado.Series.Add(series3);
            this.histogramaEqualizado.Size = new System.Drawing.Size(459, 251);
            this.histogramaEqualizado.TabIndex = 41;
            this.histogramaEqualizado.Text = "chart1";
            // 
            // btToDouble
            // 
            this.btToDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btToDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btToDouble.ForeColor = System.Drawing.Color.Black;
            this.btToDouble.Location = new System.Drawing.Point(326, 435);
            this.btToDouble.Name = "btToDouble";
            this.btToDouble.Size = new System.Drawing.Size(128, 30);
            this.btToDouble.TabIndex = 43;
            this.btToDouble.Text = "toDouble";
            this.btToDouble.UseVisualStyleBackColor = false;
            this.btToDouble.Visible = false;
            this.btToDouble.Click += new System.EventHandler(this.btToDouble_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReset.ForeColor = System.Drawing.Color.Black;
            this.btReset.Location = new System.Drawing.Point(182, 435);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(128, 30);
            this.btReset.TabIndex = 44;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // filtragemGaus
            // 
            this.filtragemGaus.Controls.Add(this.txSigmaValue);
            this.filtragemGaus.Controls.Add(this.pictureBoxKernel);
            this.filtragemGaus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filtragemGaus.Location = new System.Drawing.Point(1119, 90);
            this.filtragemGaus.Name = "filtragemGaus";
            this.filtragemGaus.Size = new System.Drawing.Size(203, 198);
            this.filtragemGaus.TabIndex = 45;
            this.filtragemGaus.TabStop = false;
            this.filtragemGaus.Text = "Filtragem Gaussiana";
            this.filtragemGaus.Visible = false;
            // 
            // pictureBoxKernel
            // 
            this.pictureBoxKernel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxKernel.Location = new System.Drawing.Point(65, 59);
            this.pictureBoxKernel.Name = "pictureBoxKernel";
            this.pictureBoxKernel.Size = new System.Drawing.Size(98, 98);
            this.pictureBoxKernel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKernel.TabIndex = 46;
            this.pictureBoxKernel.TabStop = false;
            // 
            // txSigmaValue
            // 
            this.txSigmaValue.AutoSize = true;
            this.txSigmaValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txSigmaValue.Location = new System.Drawing.Point(72, 43);
            this.txSigmaValue.Name = "txSigmaValue";
            this.txSigmaValue.Size = new System.Drawing.Size(42, 13);
            this.txSigmaValue.TabIndex = 46;
            this.txSigmaValue.Text = "Sigma: ";
            // 
            // brightnessLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1359, 843);
            this.Controls.Add(this.filtragemGaus);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btToDouble);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.histogramaEqualizado);
            this.Controls.Add(this.btAplicarFiltros);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.btAplicarMelhoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbMelhorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.brightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bright);
            this.Controls.Add(this.histogramaOriginal);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btNOT);
            this.Controls.Add(this.btXOR);
            this.Controls.Add(this.btOR);
            this.Controls.Add(this.btAND);
            this.Controls.Add(this.blendingFactor);
            this.Controls.Add(this.blending);
            this.Controls.Add(this.btRBGto8bits);
            this.Controls.Add(this.rgbToGrey);
            this.Controls.Add(this.divisaoInput);
            this.Controls.Add(this.multiplicacaoInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.load2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.load1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "brightnessLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaEqualizado)).EndInit();
            this.filtragemGaus.ResumeLayout(false);
            this.filtragemGaus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKernel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load1;
        private System.Windows.Forms.Button load2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox multiplicacaoInput;
        private System.Windows.Forms.TextBox divisaoInput;
        private System.Windows.Forms.Button rgbToGrey;
        private System.Windows.Forms.Button btRBGto8bits;
        private System.Windows.Forms.Button blending;
        private System.Windows.Forms.TextBox blendingFactor;
        private System.Windows.Forms.Button btNOT;
        private System.Windows.Forms.Button btXOR;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btAND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaOriginal;
        private System.Windows.Forms.TrackBar bright;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label brightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAplicarMelhoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMelhorias;
        private System.Windows.Forms.Button btAplicarFiltros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaEqualizado;
        private System.Windows.Forms.Button btToDouble;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox filtragemGaus;
        private System.Windows.Forms.Label txSigmaValue;
        private System.Windows.Forms.PictureBox pictureBoxKernel;
    }
}

