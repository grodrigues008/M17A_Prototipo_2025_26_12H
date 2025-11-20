using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12H
{
    public partial class F_Emprestimo : Form
    {
        BaseDados bd;
        public F_Emprestimo(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            PreencherCBLivros();
            PreencheCBLeitores();
        }

        void PreencherCBLivros()
        {
            cb_livros.Items.Clear();
            Livro.Livro l = new Livro.Livro(bd);
            DataTable dados = l.Listar();
            foreach (DataRow dr in dados.Rows)
            {
                Livro.Livro novo = new Livro.Livro(bd);
                novo.nlivro = int.Parse(dr["nlivro"].ToString());
                novo.titulo = dr["titulo"].ToString();
                novo.estado = bool.Parse(dr["estado"].ToString());
                if (novo.estado == true)
                    cb_livros.Items.Add(novo);
            }
        }

        void PreencheCBLeitores()
        {

        }
    }
}
