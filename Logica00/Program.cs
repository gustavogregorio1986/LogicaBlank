using System;
using Logica00.Control;
using Logica00.Entidade;

namespace Logica00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 10;

            Console.WriteLine("Numnero: " + valor.Numero);

            ControlaValor controlaValor = new ControlaValor();
            controlaValor.VerificarPar(valor);
        }
    }
}
