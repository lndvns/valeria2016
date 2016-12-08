using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBruxos.DAO
{
    interface IDao
    {
        bool inserir(Object objeto);
        bool atualizar(Object objeto);
        bool consultar(Object objeto);
        bool excluir(Object objeto);
    }
}
