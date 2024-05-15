namespace ProjetoJogoIngles
{
    partial class Ranking
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
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.ColumnJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJogador,
            this.ColumnPontuacao,
            this.ColumnTempo});
            this.dataGridViewRanking.Location = new System.Drawing.Point(21, 44);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.RowHeadersWidth = 51;
            this.dataGridViewRanking.RowTemplate.Height = 24;
            this.dataGridViewRanking.Size = new System.Drawing.Size(749, 319);
            this.dataGridViewRanking.TabIndex = 1;
            // 
            // ColumnJogador
            // 
            this.ColumnJogador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnJogador.HeaderText = "Jogador";
            this.ColumnJogador.MinimumWidth = 6;
            this.ColumnJogador.Name = "ColumnJogador";
            this.ColumnJogador.ReadOnly = true;
            this.ColumnJogador.Width = 87;
            // 
            // ColumnPontuacao
            // 
            this.ColumnPontuacao.HeaderText = "Pontuação";
            this.ColumnPontuacao.MinimumWidth = 6;
            this.ColumnPontuacao.Name = "ColumnPontuacao";
            this.ColumnPontuacao.ReadOnly = true;
            this.ColumnPontuacao.Width = 125;
            // 
            // ColumnTempo
            // 
            this.ColumnTempo.HeaderText = "Tempo";
            this.ColumnTempo.MinimumWidth = 6;
            this.ColumnTempo.Name = "ColumnTempo";
            this.ColumnTempo.ReadOnly = true;
            this.ColumnTempo.Width = 125;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRanking);
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTempo;
    }
}