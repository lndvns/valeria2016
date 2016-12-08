using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.Entidades
{
    abstract class Bruxo
    {
        private string nome;
        private string paisOrigem;
        private int idade;
        private string email;
        private string dataNasc;
        private int id;



        public Bruxo()
        {
            nome = null;
            paisOrigem = null;
            idade = 0;
            email = null;
            dataNasc = null;
            id = 0;

        } 
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string PaisOrigem
        {
            get { return paisOrigem; }
            set { paisOrigem = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
    }
}
