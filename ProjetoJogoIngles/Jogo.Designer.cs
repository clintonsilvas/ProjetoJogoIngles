namespace ProjetoJogoIngles
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxJogadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.panelJogo = new System.Windows.Forms.Panel();
            this.labelPontuacão = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.radioButtonOpcao1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOpcao2 = new System.Windows.Forms.RadioButton();
            this.pictureBoxImagemJogo = new System.Windows.Forms.PictureBox();
            this.radioButtonOpcao3 = new System.Windows.Forms.RadioButton();
            this.btnVerPontuacao = new System.Windows.Forms.Button();
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.panelJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxJogadores
            // 
            this.comboBoxJogadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJogadores.FormattingEnabled = true;
            this.comboBoxJogadores.Location = new System.Drawing.Point(123, 12);
            this.comboBoxJogadores.Name = "comboBoxJogadores";
            this.comboBoxJogadores.Size = new System.Drawing.Size(293, 33);
            this.comboBoxJogadores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogador:";
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(466, 12);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(129, 33);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // panelJogo
            // 
            this.panelJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelJogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJogo.Controls.Add(this.labelPontuacão);
            this.panelJogo.Controls.Add(this.btnProximo);
            this.panelJogo.Controls.Add(this.radioButtonOpcao1);
            this.panelJogo.Controls.Add(this.radioButtonOpcao2);
            this.panelJogo.Controls.Add(this.pictureBoxImagemJogo);
            this.panelJogo.Controls.Add(this.radioButtonOpcao3);
            this.panelJogo.Enabled = false;
            this.panelJogo.Location = new System.Drawing.Point(12, 74);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(776, 356);
            this.panelJogo.TabIndex = 3;
            // 
            // labelPontuacão
            // 
            this.labelPontuacão.AutoSize = true;
            this.labelPontuacão.Location = new System.Drawing.Point(172, 303);
            this.labelPontuacão.Name = "labelPontuacão";
            this.labelPontuacão.Size = new System.Drawing.Size(11, 16);
            this.labelPontuacão.TabIndex = 11;
            this.labelPontuacão.Text = "-";
            this.labelPontuacão.Visible = false;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(453, 272);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(129, 47);
            this.btnProximo.TabIndex = 9;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // radioButtonOpcao1
            // 
            this.radioButtonOpcao1.AutoSize = true;
            this.radioButtonOpcao1.Location = new System.Drawing.Point(463, 63);
            this.radioButtonOpcao1.Name = "radioButtonOpcao1";
            this.radioButtonOpcao1.Size = new System.Drawing.Size(32, 20);
            this.radioButtonOpcao1.TabIndex = 8;
            this.radioButtonOpcao1.Text = "-";
            this.radioButtonOpcao1.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpcao2
            // 
            this.radioButtonOpcao2.AutoSize = true;
            this.radioButtonOpcao2.Location = new System.Drawing.Point(463, 132);
            this.radioButtonOpcao2.Name = "radioButtonOpcao2";
            this.radioButtonOpcao2.Size = new System.Drawing.Size(32, 20);
            this.radioButtonOpcao2.TabIndex = 7;
            this.radioButtonOpcao2.Text = "-";
            this.radioButtonOpcao2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImagemJogo
            // 
            this.pictureBoxImagemJogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImagemJogo.Image = global::ProjetoJogoIngles.Properties.Resources.images;
            this.pictureBoxImagemJogo.Location = new System.Drawing.Point(46, 46);
            this.pictureBoxImagemJogo.Name = "pictureBoxImagemJogo";
            this.pictureBoxImagemJogo.Size = new System.Drawing.Size(260, 236);
            this.pictureBoxImagemJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemJogo.TabIndex = 6;
            this.pictureBoxImagemJogo.TabStop = false;
            // 
            // radioButtonOpcao3
            // 
            this.radioButtonOpcao3.AutoSize = true;
            this.radioButtonOpcao3.Location = new System.Drawing.Point(463, 204);
            this.radioButtonOpcao3.Name = "radioButtonOpcao3";
            this.radioButtonOpcao3.Size = new System.Drawing.Size(32, 20);
            this.radioButtonOpcao3.TabIndex = 5;
            this.radioButtonOpcao3.Text = "-";
            this.radioButtonOpcao3.UseVisualStyleBackColor = true;
            // 
            // btnVerPontuacao
            // 
            this.btnVerPontuacao.Location = new System.Drawing.Point(626, 443);
            this.btnVerPontuacao.Name = "btnVerPontuacao";
            this.btnVerPontuacao.Size = new System.Drawing.Size(130, 47);
            this.btnVerPontuacao.TabIndex = 10;
            this.btnVerPontuacao.Text = "Ver pontuação";
            this.btnVerPontuacao.UseVisualStyleBackColor = true;
            this.btnVerPontuacao.Visible = false;
            this.btnVerPontuacao.Click += new System.EventHandler(this.btnVerPontuacao_Click);
            // 
            // timerJogo
            // 
            this.timerJogo.Interval = 1000;
            this.timerJogo.Tick += new System.EventHandler(this.timerJogo_Tick);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.btnVerPontuacao);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxJogadores);
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Inglês";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Panel panelJogo;
        private System.Windows.Forms.RadioButton radioButtonOpcao1;
        private System.Windows.Forms.RadioButton radioButtonOpcao2;
        private System.Windows.Forms.PictureBox pictureBoxImagemJogo;
        private System.Windows.Forms.RadioButton radioButtonOpcao3;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVerPontuacao;
        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.Label labelPontuacão;
    }
}