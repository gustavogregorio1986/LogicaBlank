using Logica03.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica03.Control
{
    public class ControlaProduto
    {
        public double CalculaPreco(Produto produto)
        {
            double precoFinal = 0;
            if (produto.Quantidade <= 10)
            {
                precoFinal = (double)(produto.Preco * produto.Quantidade);
            }
            else if (produto.Quantidade > 10 && produto.Quantidade <= 20)
            {
                precoFinal = (double)(produto.Preco * produto.Quantidade * 0.9m);
            }
            else if (produto.Quantidade > 20)
            {
                precoFinal = (double)(produto.Preco * produto.Quantidade * 0.8m);
            }
            return precoFinal;
        }
    }
}
