using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaBruxos.Entidades;
using System.Data.SqlClient;
using EscolaBruxos.DAO;

namespace EscolaBruxos.Modelo
{
    class ReitorDao
    {
        internal bool inserir(Reitor reitor)
        {
            bool sucesso = false;
            Reitor reitorDao = new Reitor();
            reitorDao = (Reitor)object;

            string INSERT = "INSERT INTO Reitor " + "nome, paisOrigem, idade, email, dataNasc, diplomas, salario, tempoXp, segredo, superPoder" + reitor.Nome + reitor.PaisOrigem + reitor.Idade + reitor.Email + reitor.DataNasc + reitor.Diploma + reitor.Salario + reitor.TempoXp + reitor.Segredo + reitor.SuperPoder;

            SqlConnection conn = ConexaoBancoDados.obterConexao();

            try
            {
                SqlCommand cmd = new SqlCommand(INSERT, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Inserção");
                    cmd.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção: " + ex);
            }
            finally
            {
                ConexaoBancoDados.fecharConexao();
            }
            return sucesso;
        }
    }

        internal bool consultar(Reitor reitor)
        {
        bool sucesso = false;
        Reitor reitorDao = new Reitor();
        reitorDao = (Reitor)object;
        string SELECT = "SELECT * FROM reitor WHERE idReitor = " + reitorDao.Id;
        SqlConnection conn = ConexaoBancoDados.obterConexao();
        try
        {
            SqlCommand cmd = new SqlCommand(SELECT, conn);

            SqlDataReader DR;
            DR = cmd.ExecuteReader();
            if (DR.Read())
            {
                reitorDao.Id = Convert.ToInt32(DR["idAluno"].ToString());
                reitorDao.Nome = DR["nome"].ToString();
                reitorDao.PaisOrigem = DR["paisOrigem"].ToString();
                reitorDao.Idade = Convert.ToInt32(DR["idade"].ToString());
                reitor.Salario = Convert.ToInt32(DR["salario"].ToString());
                reitor.TempoXp = Convert.ToInt32(DR["tempoXp"].ToString());
                reitor.Segredo = DR["segredo"].ToString();
                reitor.SuperPoder = DR["superPoder"].ToString();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro de Inserção:" + ex);
        }
        finally
        {
            ConexaoBancoDados.fecharConexao();
        }
        return sucesso;
    }

}

internal bool excluir(Reitor reitor)
        {
            throw new NotImplementedException();
        }

