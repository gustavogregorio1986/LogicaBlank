using Logica5.Control;
using Logica5.Entidade;
using System;
using System.Collections.Generic;

namespace Logica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<Numero>
{
    new Numero { Valor = 10 },
    new Numero { Valor = -5 },
    new Numero { Valor = 0 },
    new Numero { Valor = 7 }
};

            var controle = new ControlaNumero();
            controle.NumeroDevalores(numeros);
        }
    }
}
