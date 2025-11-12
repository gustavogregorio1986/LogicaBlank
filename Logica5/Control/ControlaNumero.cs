using Logica5.Entidade;
using System;
using System.Collections.Generic;

namespace Logica5.Control
{
    public class ControlaNumero
    {
        public void NumeroDevalores(List<Numero> listaNumeros)
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                var numero = listaNumeros[i];

                if (numero.Valor > 0)
                {
                    Console.WriteLine($"[{i}] O número {numero.Valor} é positivo.");
                }
                else if (numero.Valor < 0)
                {
                    Console.WriteLine($"[{i}] O número {numero.Valor} é negativo.");
                }
                else
                {
                    Console.WriteLine($"[{i}] O número é zero.");
                }
            }
        }
    }
}