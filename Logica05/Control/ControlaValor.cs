using Logica05.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica05.Control
{
    public class ControlaValor
    {
        public int Antecessor(Valor valor)
        {
            return valor.Numero - 1;
        }

        public int Sucessor(Valor valor)
        {
            return valor.Numero + 1;
        }
    }
}
