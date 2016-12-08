
using EscolaBruxos.Controle;
using EscolaBruxos.DAO;
using EscolaBruxos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Modelo
{
    class AlunoDao : IDao
    {
        public bool atualizar(object objeto)
        {
            bool sucesso = false;
            return sucesso;
        }

        public bool consultar(object objeto)
        {
            bool sucesso = false;
            Aluno aluno = new Aluno();
            aluno = (Aluno)objeto;
            string SELECT = "SELECT * FROM Alunos WHERE idAluno = " + aluno.Id;
            SqlConnection conn = ConexaoBancoDados.obterConexao();
            try
            {
                SqlCommand cmd = new SqlCommand(SELECT, conn);

                SqlDataReader DR;
                DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    aluno.Id = Convert.ToInt32(DR["idAluno"].ToString());
                    aluno.Nome = DR["nome"].ToString();
                    aluno.PaisOrigem = DR["paisOrigem"].ToString();
                    aluno.Idade = Convert.ToInt32(DR["idade"].ToString());
                   
              
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

        public bool excluir(object objeto)
        {
            throw new NotImplementedException();
        }

        public bool inserir(object objeto)
        {
            bool sucesso = false;
            Aluno aluno = new Aluno();
            aluno = (Aluno)objeto;

            string INSERT = "INSERT INTO Alunos (" + "nome, paisOrigem, idade, email, dataNasc, " + "registroAcademico, casa, anoIngresso, " + "magia, numeroSerie, nomeVassoura, potencia)" + "values ('" + aluno.Nome + "', '" + aluno.PaisOrigem + "', '" + aluno.Idade + "', '" + aluno.Email + "', '" + aluno.DataNasc + "', '" + aluno.Ra + "', '" + aluno.Casa + "', '" + aluno.AnoIngresso + "', '" + aluno.Magia + "', '" + aluno.VassouraVoadora.Numero + "', '" + aluno.VassouraVoadora.Nome + "', '" + aluno.VassouraVoadora.Potencia + "')";

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
        public bool consultar(object objeto)
        {
            bool sucesso = false;
            Aluno aluno = new Aluno();
            aluno = (Aluno)objeto;
            string SELECT = "SELECT * FROM Alunos WHERE idAluno=" + aluno.Id;
            SqlConnection conn = ConexaoBancoDados.obterConexao();
            try
            {
                SqlCommand cmd = new SqlCommand(SELECT, conn);
                SqlDataReader DR;
                DR = cmd.ExecuteReader();
                if(DR.Read())
                {
                    aluno.Id = Convert.ToInt32(DR["idAluno"].ToString());
                    aluno.Nome = DR["nome"].ToString();
                    aluno.PaisOrigem = DR["paisOrigem"].ToString();
                    aluno.Idade =Convert.ToInt32( DR["idade"].ToString());
                    aluno.Email = DR["email"].ToString();
                    aluno.DataNasc = DR["dataNasc"].ToString();
                    aluno.Ra = Convert.ToInt32(DR["Ra"]);
                    aluno.Casa = DR["casa"].ToString();
                    aluno.AnoIngresso = Convert.ToInt32(DR["anoIngresso"].ToString());
                    aluno.Magia = DR["magia"].ToString();
                    aluno.VassouraVoadora.Numero = Convert.ToInt32(DR["numeroSerie"].ToString());
                    aluno.VassouraVoadora.Nome = DR["nomeVassoura"].ToString();
                    aluno.VassouraVoadora.Potencia = Convert.ToInt32(DR["potencia"].ToString());

                    

           
        {
            bool sucesso = false;
            Aluno aluno = new Aluno();
            aluno = (Aluno)objeto;
            string DELETE = "DELETE FROM Alunos WHERE idAluno= " + aluno.Id;
            SqlConnection conn = ConexaoBancoDados.obterConexao();
            try
            {
                SqlCommand cmd = new SqlCommand(DELETE, conn);
                if(cmd.ExecuteNonQuery()== 1)
                {
                    Console.WriteLine("Sucesso na Exclusão");
                    cmd.Dispose();
                    sucesso = true;
                }
            }catch (SqlException ex)
            {
                Console.WriteLine("Erro de Exclusão " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
                
            }
        }
    }
}
