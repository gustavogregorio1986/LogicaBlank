using Logica3.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica3.Control
{
    public class Tabuada
    {
        public void ExibirTabuada(Valor valor)
        {
            Console.WriteLine($"Tabuada do {valor.Numero}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = valor.Numero * i;
                Console.WriteLine($"{valor.Numero} x {i} = {resultado}");
            }
        }


    }
}
