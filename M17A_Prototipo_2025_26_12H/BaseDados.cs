using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace M17A_Prototipo_2025_26_12H
{
    /// <summary>
    /// Responsável por executar comandos SQL na base de dados
    /// </summary>

    public class BaseDados
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
            ligacaoSQL = new SqlConnection(strligacao);
            ligacaoSQL.Open();
            ligacaoSQL.ChangeDatabase(this.NomeBD);
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

            // verificar se a bd já existe no catalogo
            string sql = $@"
                        IF EXISTS(SELECT * FROM master.sys.databases
                                      WHERE name='{this.NomeBD}')
                           BEGIN
                                USE [master]
                                EXEC sp_detach_db {this.NomeBD};
                            END
                        ";

            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();

            //criar a bd
            sql = $"CREATE DATABASE {this.NomeBD} ON PRIMARY (NAME={this.NomeBD},FILENAME='{this.CaminhoBD}')";
            comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            // Associação a ligação à base de dados criada
            ligacaoSQL.ChangeDatabase(this.NomeBD);
            // criar as tabelas
            // criar tabela livros
            sql = @"CREATE TABLE Livros(
                    nlivro int identity primary key,
                    titulo varchar(50) not null,
                    autor varchar(100),
                    editora varchar(100),
                    isbn varchar(13),
                    ano int check (ano > 0),
                    data_aquisicao date default getdate(),
                    preco money,
                    capa varchar(500),
                    estado bit default 1,
                    );";

            //TODO: faltam as tabelas leitores e empréstimos
            comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            comando.Dispose();

        }

        // função para executar comando sql (insert/delete/update/create/alter...)
        public void ExecutarSQL(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null) 
                comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
            comando.Dispose();
        }

        // função para executar um select e devolver os registos da bd
        public DataTable DevolveSQL(string sql, List<SqlParameter> parametros=null)
        {
            DataTable dados = new DataTable();
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null)
                comando.Parameters.AddRange(parametros.ToArray());
            SqlDataReader registos = comando.ExecuteReader();
            dados.Load(registos);
            registos.Close();
            comando.Dispose();
            return dados;
        }

    }
}
