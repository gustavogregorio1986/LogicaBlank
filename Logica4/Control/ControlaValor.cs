using Logica4.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica4.Control
{
    public class ControlaValor
    {
        public int Acessor(Valor valor)
        {
            int acessor = 0;
            acessor = valor.Numero - 1;
            return acessor;
        }
    }
}
