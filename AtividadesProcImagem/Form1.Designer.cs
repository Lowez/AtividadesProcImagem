namespace AtividadesProcImagem
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.blending = new System.Windows.Forms.Button();
            this.blendingFactor = new System.Windows.Forms.TextBox();
            this.btNOT = new System.Windows.Forms.Button();
            this.btXOR = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btAND = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.load1.ForeColor = System.Drawing.Color.Black;
            this.load1.Location = new System.Drawing.Point(84, 305);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(109, 30);
            this.load1.TabIndex = 2;
            this.load1.Text = "Carregar Imagem 1";
            this.load1.UseVisualStyleBackColor = false;
            this.load1.Click += new System.EventHandler(this.load1_Click_1);
            // 
            // load2
            // 
            this.load2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.load2.Location = new System.Drawing.Point(339, 305);
            this.load2.Name = "load2";
            this.load2.Size = new System.Drawing.Size(109, 30);
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
            this.adicao.Location = new System.Drawing.Point(554, 90);
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
            this.subtracao.Location = new System.Drawing.Point(554, 157);
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
            this.multiplicacao.Location = new System.Drawing.Point(554, 226);
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
            this.divisao.Location = new System.Drawing.Point(554, 288);
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
            this.pictureBox3.Location = new System.Drawing.Point(804, 90);
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
            this.label1.Location = new System.Drawing.Point(809, 46);
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
            this.multiplicacaoInput.Location = new System.Drawing.Point(621, 239);
            this.multiplicacaoInput.Name = "multiplicacaoInput";
            this.multiplicacaoInput.Size = new System.Drawing.Size(43, 20);
            this.multiplicacaoInput.TabIndex = 13;
            // 
            // divisaoInput
            // 
            this.divisaoInput.Location = new System.Drawing.Point(621, 301);
            this.divisaoInput.Name = "divisaoInput";
            this.divisaoInput.Size = new System.Drawing.Size(43, 20);
            this.divisaoInput.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(38, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "RGB -> GreyScale";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(180, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "GreyScale -> RGB";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // blending
            // 
            this.blending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.blending.ForeColor = System.Drawing.Color.Black;
            this.blending.Location = new System.Drawing.Point(321, 384);
            this.blending.Name = "blending";
            this.blending.Size = new System.Drawing.Size(126, 30);
            this.blending.TabIndex = 17;
            this.blending.Text = "Blending";
            this.blending.UseVisualStyleBackColor = false;
            this.blending.Click += new System.EventHandler(this.blending_Click);
            // 
            // blendingFactor
            // 
            this.blendingFactor.Location = new System.Drawing.Point(454, 390);
            this.blendingFactor.Name = "blendingFactor";
            this.blendingFactor.Size = new System.Drawing.Size(43, 20);
            this.blendingFactor.TabIndex = 18;
            // 
            // btNOT
            // 
            this.btNOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btNOT.Location = new System.Drawing.Point(705, 288);
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
            this.btXOR.Location = new System.Drawing.Point(705, 226);
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
            this.btOR.Location = new System.Drawing.Point(705, 157);
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
            this.btAND.Location = new System.Drawing.Point(705, 90);
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
            this.label4.Location = new System.Drawing.Point(551, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aritméticos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(702, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lógicos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1046, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btNOT);
            this.Controls.Add(this.btXOR);
            this.Controls.Add(this.btOR);
            this.Controls.Add(this.btAND);
            this.Controls.Add(this.blendingFactor);
            this.Controls.Add(this.blending);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button blending;
        private System.Windows.Forms.TextBox blendingFactor;
        private System.Windows.Forms.Button btNOT;
        private System.Windows.Forms.Button btXOR;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btAND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

