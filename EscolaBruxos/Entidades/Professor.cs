using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    class Professor : Funcionario
    {
        private string disciplinaLecionar;
        private string poder;

        public Professor(): base()
        {
            disciplinaLecionar = null;
            poder = null;
        
        }
        public string DisciplinaLecionar
        {
            get { return disciplinaLecionar; }
            set { disciplinaLecionar = value; }
        }
        public string Poder
        {
            get { return poder; }
            set { poder = value; }
        }
        //implementação do método Abstrato.Obrigatorio devido a herança da classe abstrata
        public override void calcularSalario(int qtdHoras, double valorHoraAula)
        {
            Salario = (qtdHoras * valorHoraAula) * 4.5;
        }
    }   
}
