using System;
using Logica.Control;
using Logica.Entidade;

namespace Logica
{
    public class Program
    {
        static void Main(string[] args)
        {
             Valor valor = new Valor();
             valor.Numero1 = 10;
             valor.Numero2 = 5;

            Console.WriteLine("Numero1: " + valor.Numero1);
            Console.WriteLine("Numero2: " + valor.Numero2);

            ControlaValor controla = new ControlaValor();
            Console.WriteLine("Soma: " + controla.Somar(valor));
            Console.WriteLine("Subtração: " + controla.Subtrair(valor));
            Console.WriteLine("Multiplicação: " + controla.Multiplicar(valor));
            Console.WriteLine("Divisão: " + controla.Dividir(valor));
        }
    }
}
