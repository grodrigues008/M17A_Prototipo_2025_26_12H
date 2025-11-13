using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12H.Livro
{
    public partial class F_Livro : Form
    {
        string capa = "";

        public F_Livro()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // Botão para procurar a imagem para a capa
        private void bt_procurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ficheiro = new OpenFileDialog();
            ficheiro.InitialDirectory = "C:\\";
            ficheiro.Multiselect = false;
            ficheiro.Filter = "Imagens |*.jpg;*.jpeg;*.png;*.bmp | Todos os ficheiros |*.*";
            if (ficheiro.ShowDialog() == DialogResult.OK)
            {
                string temp = ficheiro.FileName;
                if (System.IO.File.Exists(temp))
                {
                    pb_capa.Image = Image.FromFile(temp);
                    capa = temp;
                }
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            // criar um objeto do tipo livro
            // preencher os dados do livro
            // validar os dados
            // se não tiver erros nos dados
            // guardar na base de dados
            // copiar a capa para a pasta do programa
            // limpar o form
            // atualizar a lista dos livros na datagrid
            // feedback user
        }
    }
}
