using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void Apagar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
