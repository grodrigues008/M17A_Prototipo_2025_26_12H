using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace M17A_Prototipo_2025_26_12H.Livro
{
    /// <summary>
    /// Dados do Livro e funções para materializar os dados na BD
    /// </summary>

    internal class Livro : IItem
    {
        public int nlivro {  get; set; }
        public string titulo { get; set; }
        public string editora { get; set; }
        public string autor {  get; set; }
        public string isbn {  get; set; }
        public int ano { get; set; }
        public DateTime data_aquisicao { get; set; }
        public Decimal preco { get; set; }
        public string capa { get; set; }
        public bool estado { get; set; }

        BaseDados bd;

        public Livro(BaseDados bd)
        {
            this.bd = bd;
        }

        // Executa o comando INSERT na base de dados
        public void Adicionar()
        {
            string sql = @"INSERT INTO Livros(titulo,autor,editora,isbn,ano,data_aquisicao,preco,capa) VALUES 
                          (@titulo,@autor,@editora,@isbn,@ano,@data_aquisicao,@preco,@capa)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@titulo",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.titulo
                },

                new SqlParameter()
                {
                    ParameterName = "@autor",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.autor
                },

                new SqlParameter()
                {
                    ParameterName = "@editora",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.editora
                },

                new SqlParameter()
                {
                    ParameterName = "@isbn",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.isbn
                },

                new SqlParameter()
                {
                    ParameterName = "@ano",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value = this.ano
                },

                new SqlParameter()
                {
                    ParameterName = "@data_aquisicao",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value = this.data_aquisicao
                },

                new SqlParameter()
                {
                    ParameterName = "@preco",
                    SqlDbType=System.Data.SqlDbType.Money,
                    Value = this.preco
                },

                new SqlParameter()
                {
                    ParameterName = "@capa",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.capa
                },
            };
            bd.ExecutarSQL(sql, parametros);
        }

        public void Apagar()
        {
            string sql = "DELETE FROM Livro WHERE nlivro=" + nlivro;
        }

        public void Atualizar()
        {
            string sql = @"UPDATE Livros SET titulo=@titulo,autor=@autor,editora=@editora,isbn=@isbn,ano=@ano,data_aquisicao=@data_aquisicao,preco=@preco,capa=@capa WHERE nlivro=@nlivro";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@titulo",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.titulo
                },

                new SqlParameter()
                {
                    ParameterName = "@autor",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.autor
                },

                new SqlParameter()
                {
                    ParameterName = "@editora",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.editora
                },

                new SqlParameter()
                {
                    ParameterName = "@isbn",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.isbn
                },

                new SqlParameter()
                {
                    ParameterName = "@ano",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value = this.ano
                },

                new SqlParameter()
                {
                    ParameterName = "@data_aquisicao",
                    SqlDbType=System.Data.SqlDbType.Date,
                    Value = this.data_aquisicao
                },

                new SqlParameter()
                {
                    ParameterName = "@preco",
                    SqlDbType=System.Data.SqlDbType.Money,
                    Value = this.preco
                },

                new SqlParameter()
                {
                    ParameterName = "@capa",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value = this.capa
                },
            };
            bd.ExecutarSQL(sql, parametros);
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();
            // validar titulo
            if (String.IsNullOrEmpty(titulo) || titulo.Length < 3)
            {
                erros.Add("O campo título deve ter pelo menos 3 letras");
            }

            // validar ano
            if(ano<=0 || ano > DateTime.Now.Year)
            {
                erros.Add("O campo ano deve ter um valor superior a 0 e inferior ao ano atual.");
            }
            return erros;
        }

        public DataTable Listar()
        {
            return bd.DevolveSQL("SELECT nlivro, titulo, autor, editora FROM Livros ORDER BY titulo");
        }


        /// <summary>
        /// Pesquisa o nlivro na bd e preenche as propriedades do objeto
        /// </summary>
        public void Procurar()
        {
            string sql = "SELECT * FROM LIVROS WHERE nlivro=" + nlivro;
            DataTable temp = bd.DevolveSQL(sql);
            if (temp != null && temp.Rows.Count > 0)
            {
                DataRow linha = temp.Rows[0];
                this.titulo = linha["titulo"].ToString();
                this.isbn = linha["isbn"].ToString();
                this.preco = Decimal.Parse(linha["preco"].ToString());
                this.autor = linha["autor"].ToString();
                this.data_aquisicao = DateTime.Parse(linha["data_aquisicao"].ToString());
                this.ano = int.Parse(linha["ano"].ToString());
                this.capa = linha["capa"].ToString();
                this.editora = linha["editora"].ToString();
                this.estado = bool.Parse(linha["estado"].ToString());
            }
        }
    }


}
