using System;
using exercicio7.src;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
           Gerente gerente = new Gerente("Wanderley", 40, 20000.00);
           Supervisor supervisor = new Supervisor("Clecio", 20, 10000.00);
           Vendedor vendedor = new Vendedor("Michel", 29, 1600.00);

           System.Console.WriteLine(gerente.Bonificacao()); 
           System.Console.WriteLine(supervisor.Bonificacao());
           System.Console.WriteLine(vendedor.Bonificacao());
        }
    }
}
