using EscolaBruxos.Entidades;
using EscolaBruxos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaBruxos.Controle
{
    class AlunoControle
    {
        public void inserirAluno(Aluno aluno)
        {
            //Objeto alunoDao ira levar os dados do objeto aluno para a camada Modelo
            AlunoDao alunoDao = new AlunoDao();
            if (alunoDao.inserir(aluno))
            {
                MessageBox.Show("Aluno Cadastrado com Sucesso");
            }
            else
            {
                MessageBox.Show("Aluno Não Cadastrada");
            }
            alunoDao = null;
        }
        
        public bool consultarAluno(Aluno aluno)
        {
            if (aluno.Id > 0)
            {
                AlunoDao alunoDao = new AlunoDao();
                return alunoDao.consultar(aluno);
            }
            else
            {
                return false;
            }
        }
        public void excluirAluno(Aluno aluno)
        {
            if (aluno.Id > 0)
            {
                AlunoDao alunoDao = new AlunoDao();
                if (alunoDao.excluir(aluno))
                {
                    MessageBox.Show("Dados exluidos com Sucesso");
                }
                else
                {
                    MessageBox.Show("Dados não excluidos");
                }
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
        }
        
        }
}
