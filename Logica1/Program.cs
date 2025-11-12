using System;
using Logica1.Control;
using Logica1.Entidade;

namespace Logica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 13;

            Console.WriteLine("Numero: " + valor.Numero);

            ControlaValor control = new ControlaValor();
            control.VerificarPar(valor);
        }
    }
}
