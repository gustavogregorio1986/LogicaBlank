using System;
using Logica05.Control;
using Logica05.Entidade;

namespace Logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 23;

            Console.WriteLine("Numero: " + valor.Numero);

            ControlaValor control = new ControlaValor();    
            int antecessor = control.Antecessor(valor);
            int sucessor = control.Sucessor(valor);

            Console.WriteLine("Antecessor: " + antecessor);
            Console.WriteLine("Sucessor: " + sucessor);
        }
    }
}
