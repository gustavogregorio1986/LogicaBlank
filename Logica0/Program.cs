using Logica0.Control;
using Logica0.Entidade;
using System;

namespace Logica0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 10;
            Console.WriteLine("Numero: " + valor.Numero);

            Controlavalor controlavalor = new Controlavalor();
            Console.WriteLine("PO dobro é: " + controlavalor.Dobro(valor));
        }
    }
}
