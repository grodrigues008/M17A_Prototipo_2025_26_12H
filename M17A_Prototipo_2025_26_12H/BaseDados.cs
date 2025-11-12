using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace M17A_Prototipo_2025_26_12H
{
    /// <summary>
    /// Responsável por executar comandos SQL na base de dados
    /// </summary>

    internal class BaseDados
    {
        string strligacao;
        string NomeBD;
        string CaminhoBD;
        SqlConnection ligacaoSQL;


        //construtor
        // Estabelece a ligação à BD, caso não exista cria a BD
        public BaseDados(string NomeBD)
        {
            this.NomeBD = NomeBD;
            //Ler a string ligação
            strligacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            // Verificar a pasta do projeto
            CaminhoBD = Utils.PastaDoPrograma("M17A_Biblioteca");
            CaminhoBD += @"\" + NomeBD + ".mdf";
            // Verificar se a bd existe
            if (System.IO.File.Exists(CaminhoBD) == false)
            {
                // Se não existir
                // criar a bd
                //TODO: verificar se a bd existe no catálogo
                CriarBD();
            }

            // Ligação à BD
        }


        // desconstrutor
        ~BaseDados()
        {
            //fechar a ligação à bd
        }

        void CriarBD()
        {
            //ligação ao servidor
            ligacaoSQL = new SqlConnection(strligacao);
            ligacaoSQL.Open();
            //criar a bd
            SqlCommand comando = new SqlCommand();
            // criar as tabelas
        }

    }
}
