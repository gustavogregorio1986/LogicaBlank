using System;
using Logica4.Control;
using Logica4.Entidade;

namespace Logica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 10;

            Console.WriteLine("Numero: " + valor.Numero);

            ControlaValor controlaValor = new ControlaValor();
            int resultado = controlaValor.Acessor(valor);
            Console.WriteLine($"O antecessor é {resultado}");
        }
    }
}
