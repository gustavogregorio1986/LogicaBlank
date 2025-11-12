using Logica02.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica02.Control
{
    public class ControlaTriangulo
    {
        public double CalculoTriangulo(Triangulo triangulo)
        {
            double calculo = 0.0;
            calculo = (triangulo.Base * triangulo.Qauntidade) / 2;
            return calculo;
        }
    }
}
