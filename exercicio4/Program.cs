using System.Collections.Generic;
using exercicio4.src;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercício 4
            Pessoa pessoa1 = new Pessoa("João", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 17);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(pessoa1);
            lista.Add(pessoa2);
            lista.Add(pessoa3);
            lista.Add(pessoa4);
            
            Pessoa.MaiorIdade(lista);

            //exercício 5
            Pessoa.TotalDePessoas(lista); 
            Pessoa.RemoverMenores18(lista);
            Pessoa.TotalDePessoas(lista);    
         
            //exercício 6
            Pessoa.ProcurarPessoa(lista, "Jessica");
        }
    }
}
