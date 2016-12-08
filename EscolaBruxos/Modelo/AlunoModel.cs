using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaBruxos.Entidades;
using EscolaBruxos.Modelo;

namespace EscolaBruxos.Modelo 
{
    /*
    class AlunoModel : Model
    {
        
       internal void Create(Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Alunos(nome, idade) Values(@nome, @idade)";
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@nome", a.Idade);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();          

        }
        
    }
}
