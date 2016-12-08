using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    class Aluno : Bruxo
    {
        private int ra;
        private string casa;
        private int anoIngresso;
        private string magia;
        private VassouraVoadora vassouraVoadora;

        public Aluno():base()
        {
            ra = 0;
            casa = null;
            anoIngresso = 0;
            magia = null;
            vassouraVoadora = new VassouraVoadora();
        }

        public int Ra
        {
            get { return ra; }
            set { ra = value; }
        }
        public string Casa
        {
            get { return casa; }
            set { casa = value; }
        }
        public int AnoIngresso
        {
            get { return anoIngresso; }
            set {  anoIngresso = value; }
        }
        public string Magia
        {
            get { return magia; }
            set { magia = value; }
        }
        public VassouraVoadora VassouraVoadora
        {
            get { return vassouraVoadora; }
            set { vassouraVoadora= value; }
        }

    }
}
