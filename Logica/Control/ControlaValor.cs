using Logica.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Control
{
    public class ControlaValor
    {
        public double Somar(Valor valor)
        {
            double soma = 0;
            soma = valor.Numero1 + valor.Numero2;
            return soma;
        }

        public double Subtrair(Valor valor)
        {
            double subtracao = 0;
            subtracao = valor.Numero1 - valor.Numero2;
            return subtracao;
        }

        public double Multiplicar(Valor valor)
        {
            double multiplicacao = 0;
            multiplicacao = valor.Numero1 * valor.Numero2;
            return multiplicacao;
        }

        public double Dividir(Valor valor)
        {
            double divisao = 0;
            divisao = valor.Numero1 / valor.Numero2;
            return divisao;
        }
    }
}
