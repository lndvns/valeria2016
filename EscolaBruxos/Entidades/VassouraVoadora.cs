using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    class VassouraVoadora
    {
        private int numero;
        private string nome;
        private double potencia;

        public VassouraVoadora()
        {
            numero = 0;
            nome = null;
            potencia = 0.0;
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value;}
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
    }
}
