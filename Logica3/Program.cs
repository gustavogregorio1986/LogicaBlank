using Logica3.Control;
using Logica3.Entidade;
using System;

namespace Logica3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();
            valor.Numero = 7;
            Console.WriteLine("Valor é: " + valor.Numero);
            Tabuada tabuada = new Tabuada();
            tabuada.ExibirTabuada(valor);
        }
    }
}
