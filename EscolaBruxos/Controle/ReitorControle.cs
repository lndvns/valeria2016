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
    class ReitorControle
    {
        public void inserirAluno(Reitor reitor)
        {
            //Objeto alunoDao ira levar os dados do objeto aluno para a camada Modelo
            ReitorDao reitorDao = new ReitorDao();
            if (reitorDao.inserir(reitor))
            {
                MessageBox.Show("Aluno Cadastrado com Sucesso");
            }
            else
            {
                MessageBox.Show("Aluno Não Cadastrada");
            }
            reitorDao = null;
        }

        public bool consultarReitor(Reitor reitor)
        {
            if (reitor.Id > 0)
            {
                ReitorDao reitorDao = new ReitorDao();
                return reitorDao.consultar(reitor);
            }
            else
            {
                return false;
            }
        }
        public void excluirReitor(Reitor reitor)
        {
            if (reitor.Id > 0)
            {
                ReitorDao reitorDao = new ReitorDao();
                if (reitorDao.excluir(reitor))
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
