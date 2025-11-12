using System;
using Logica2.Control;
using Logica2.Entidade;

namespace Logica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Propriedade = "segunda";
            Console.WriteLine("Propriedade: " + valor.Propriedade);

            ControlaValor controlaValor = new ControlaValor();
            controlaValor.ValorMetodo(valor);
        }
    }
}
