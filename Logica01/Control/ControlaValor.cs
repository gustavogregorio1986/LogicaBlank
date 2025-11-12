using Logica01.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica01.Control
{
    public class ControlaValor
    {
        public double GanhosDedesciontos(Funcionario funcionario)
        {
            if(funcionario.Salario >= 2000.00)
            {
                return funcionario.Salario - (funcionario.Salario * 0.20);
            }
            else if (funcionario.Salario >= 5000.00)
            {
                return funcionario.Salario - (funcionario.Salario * 0.50);
            }
            else if (funcionario.Salario >= 10000.00)
            {
                return funcionario.Salario - (funcionario.Salario * 0.80);
            }

            return funcionario.Salario;
        }
    }
}
