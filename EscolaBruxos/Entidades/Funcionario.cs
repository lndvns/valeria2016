using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    abstract class Funcionario: Bruxo
    {
        private int diploma;
        private double salario;

        public Funcionario():base()
        {
            diploma = 0;
            salario = 0.0;
        }

        public int Diploma
        {
            get { return diploma; }
            set { diploma = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public abstract void calcularSalario(int qtdHoras, double valorHoraAula);
    }
}
