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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txtNomeJogador.Text != "")
            {
                Jogador jogador = new Jogador();
                jogador.Nome = txtNomeJogador.Text;
                Program.listaJogadores.Add(jogador);
                MessageBox.Show("Cadastrado com sucesso.");
                txtNomeJogador.Clear();
            }
            else
            {
                MessageBox.Show("Digite um nome.");
            }
        }
    }
}
