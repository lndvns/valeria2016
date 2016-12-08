using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.DAO
{
    class ConexaoBancoDados
    {
        internal static void fecharConexao()
        {
            throw new NotImplementedException();
        }

        internal static SqlConnection obterConexao()
        {
            throw new NotImplementedException();
        }
    }
        // Vamos nos conectar ao SQL Server SQLServer e à base de dados
        // escolaBruxosDB usando autenticação do Windows com o SQL Server

       private static string connectiongStringWindows="data source=localhost; " +  
            "initial catalog = escolaBruxosDB; persist security info = True; " + "Integrated Security = SSPI;" ;

         //vamos nos conectar ao SQL Server e à base de dados 
         //escolaBruxosDB usando autenticação do SQL Server
        //private static string connStringSQLServer = " DATA SOURCE = localhost; " + " INITIAL CATALOG = escolaBruxosDB" + " USER ID =xxx; " + " Password = xxx;";

        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connectiongStringWindows);
            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador de método
                conn.Open();
                Console.WriteLine(" Conexão Ok");

            }
            catch(SqlException sqle)
            {
                conn = null;
                Console.WriteLine(" Conexão Error: " + sqle);
                // ops! o que aconteceu?
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();

            }

        }

    }
}