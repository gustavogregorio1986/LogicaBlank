using Logica00.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica00.Control
{
    public class ControlaValor
    {
        public void VerificarPar(Valor valor)
        {
            if (valor.Numero % 2 == 0)
            {
                Console.WriteLine("O número " + valor.Numero + " é par.");
            }
        }
    }
}
