using System;
using Logica02.Control;
using Logica02.Entidade;

namespace Logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Base = 56.4;
            triangulo.Qauntidade = 5;

            Console.WriteLine("Base: " + triangulo.Base);
            Console.WriteLine("Quantidade: " + triangulo.Qauntidade);

            ControlaTriangulo controlaTriangulo = new ControlaTriangulo();
            double resultado = controlaTriangulo.CalculoTriangulo(triangulo);
            Console.WriteLine("Resultado do Cálculo: " + resultado);
        }
    }
}
