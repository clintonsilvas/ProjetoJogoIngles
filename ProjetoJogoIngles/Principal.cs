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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.ShowDialog();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.ShowDialog();
        }
    }
}
