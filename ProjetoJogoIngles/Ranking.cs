﻿using System;
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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            foreach(Jogador item in Program.listaJogadores)
            {
                dataGridViewRanking.Rows.Add(item.Nome, item.Pontos, item.Tempo);
                
            }
        }
    }
}
