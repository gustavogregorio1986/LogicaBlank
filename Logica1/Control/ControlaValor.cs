using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1.Control
{
    public class ControlaValor
    {
        public void VerificarPar(Entidade.Valor valor)
        {
            if (valor.Numero % 2 == 0)
            {
                Console.WriteLine("O número " + valor.Numero + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + valor.Numero + " é ímpar.");
            }
        }
    }
}
