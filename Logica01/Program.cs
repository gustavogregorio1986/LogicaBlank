using System;
using Logica01.Control;
using Logica01.Entidade;

namespace Logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.NomeFuncionario = "João Silva";
            funcionario.EnailFuncionario = "joaosilva@gmail.com";
            funcionario.Funcao = "Desenvolvedor";
            funcionario.Cpf = "123.456.789-00";
            funcionario.Salario = 5000.00;

            Console.WriteLine("Nome do Funcionario: " + funcionario.NomeFuncionario);
            Console.WriteLine("Email do Funcionario: " + funcionario.EnailFuncionario);
            Console.WriteLine("Função do Funcionario: " + funcionario.Funcao);
            Console.WriteLine("CPF do Funcionario: " + funcionario.Cpf);
            Console.WriteLine("Salário do Funcionario: R$ " + funcionario.Salario);

            ControlaValor controlaValor = new ControlaValor();
            double salarioLiquido = controlaValor.GanhosDedesciontos(funcionario);
            Console.WriteLine("Salário Líquido do Funcionario: R$ " + salarioLiquido);
        }
    }
}
