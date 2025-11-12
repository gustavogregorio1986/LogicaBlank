using Logica2.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica2.Control
{
    public class ControlaValor
    {
        public void ValorMetodo(Valor valor)
        {
            switch (valor.Propriedade) { 
                 case "segunda":
                    Console.WriteLine("Valor é segunda dia de semana");
                    break;
                case "terça":
                    Console.WriteLine("Valor é terça dia de semana");
                    break;
                case "quarta":
                    Console.WriteLine("Valor é quarta dia de semana");
                    break;
                case "quinta":
                    Console.WriteLine("Valor é quinta dia de semana");
                    break;
                case "sexta":
                    Console.WriteLine("Valor é sexta dia de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Valor é sabado fim de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Valor é domingo fim de semana");
                    break;
                default:
                    Console.WriteLine("Não é valida essa opção");
                    break;
            }

        }
    }
}
