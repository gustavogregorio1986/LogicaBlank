using Logica04.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica04.Control
{
    public class ControlaCampo
    {
        public int Sucessor(Campo  campo)
        {
            int sucessor = 0;
            sucessor = campo.Numero + 1;
            return sucessor;
        }
    }
}
