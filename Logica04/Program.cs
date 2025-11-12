using System;
using Logica04.Entidade;
using Logica04.Control;

namespace Logica04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Campo campo = new Campo();
            campo.Numero = 10;

            Console.WriteLine("Numero: " + campo.Numero);

            ControlaCampo controlaCampo = new ControlaCampo();
            int sucessor = controlaCampo.Sucessor(campo);
            Console.WriteLine("Sucessor: " + sucessor);
        }
    }
}
