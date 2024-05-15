using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogoIngles
{
    public partial class Jogo : Form
    {
        private int contador;
        private int pontuacao;
        private int tempo;
        public Jogo()
        {
            InitializeComponent();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            foreach (Jogador jogador in Program.listaJogadores)
            {
                comboBoxJogadores.Items.Add(jogador.Nome);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if(comboBoxJogadores.SelectedIndex != -1)
            {   panelJogo.Enabled = true;
                jogo();
                comboBoxJogadores.Enabled = false;
                btnJogar.Enabled = false;
                timerJogo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um jogador");
            }            
        }

        private void jogo()
        {
            radioButtonOpcao1.Checked = false;
            radioButtonOpcao2.Checked = false;
            radioButtonOpcao3.Checked = false;
            switch (contador)
            {
                
                case 0:
                    pictureBoxImagemJogo.Image = Properties.Resources.arvore;
                    radioButtonOpcao1.Text = "TREE";
                    radioButtonOpcao2.Text = "FLOWER";
                    radioButtonOpcao3.Text = "FLOREST";
                    
                    break;
                case 1:
                    pictureBoxImagemJogo.Image = Properties.Resources.carro;
                    radioButtonOpcao1.Text = "MOTOR";
                    radioButtonOpcao2.Text = "CAR";
                    radioButtonOpcao3.Text = "TRUCK";
                    
                    break;
                case 2:
                    pictureBoxImagemJogo.Image = Properties.Resources.images;
                    radioButtonOpcao1.Text = "NOTBOOK";
                    radioButtonOpcao2.Text = "NOTEPAD";
                    radioButtonOpcao3.Text = "BOOK";
                    if (radioButtonOpcao3.Checked) { pontuacao++; }
                    break;
                default:
                    timerJogo.Enabled = false;
                    MessageBox.Show("Jogo encerrado");
                    Program.listaJogadores[comboBoxJogadores.SelectedIndex].Pontos = pontuacao;
                    panelJogo.Enabled = false;    
                    labelPontuacão.Visible = true;
                    labelPontuacão.Text = "Pontos: " + Program.listaJogadores[comboBoxJogadores.SelectedIndex].Pontos.ToString();
                    Program.listaJogadores[comboBoxJogadores.SelectedIndex].Tempo = tempo.ToString();
                    btnProximo.Enabled = false;
                    btnVerPontuacao.Visible = true;
                    break;

            }
        }

        private void Gabarito()
        {
            switch (contador)
            {
                case 0:
                    if (radioButtonOpcao1.Checked) { pontuacao++; } 
                    break;
                case 1:
                    if (radioButtonOpcao2.Checked) { pontuacao++; }
                    break;
                case 2:
                    if (radioButtonOpcao3.Checked) { pontuacao++; }
                    break;             
                    
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Gabarito();
            contador++;            
            jogo();
            
        }

        private void btnVerPontuacao_Click(object sender, EventArgs e)
        {
            
            Ranking ranking = new Ranking();
            ranking.ShowDialog();

        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            tempo++;
        }
    }
}
