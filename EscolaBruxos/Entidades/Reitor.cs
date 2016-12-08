using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    class Reitor:Funcionario
    {
        private int tempoXp;
        private string segredo;
        private string superPoder;

        public Reitor():base()
        {
            tempoXp = 0;
            segredo = null;
            superPoder = null;
        }

        public int TempoXp
        {
            get { return tempoXp; }
            set { tempoXp = value; }
        }
        public string Segredo
        {
            get { return segredo; }
            set { segredo = value; }
        }
        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }

        public override void calcularSalario(int qtdHoras, double valorHoraAula)
        {
            Salario = ((qtdHoras * valorHoraAula) * 4.5) + 0.5 * ((qtdHoras * valorHoraAula) * 4.5);
        }
    }
}
