using M17A_Prototipo_2025_26_12H.Livro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12H
{
    public partial class F_principal : Form
    {
        BaseDados bd;
        public F_principal()
        {
            InitializeComponent();
            bd = new BaseDados("biblioteca_12h");
        }

        private void F_principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Ficheiro --> Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Editar -> Livros
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Livro f = new F_Livro(bd);
            f.Show();
        }
    }
}
