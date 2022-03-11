using System.Collections.Generic;
using System.Linq;

namespace exercicio4.src
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa()
        {
            
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }

        public static string MaiorIdade(List<Pessoa> lista)
        {
            List<Pessoa> listaOrdenada = lista.OrderBy(x => x.Idade).ToList();
            System.Console.WriteLine(listaOrdenada.Last());
            return listaOrdenada.Last().ToString();
        }

        public static void TotalDePessoas(List<Pessoa> lista)
        {
            System.Console.WriteLine($"Quantidade de pessoas na lista: {lista.Count}");
        }

        public static List<Pessoa> RemoverMenores18(List<Pessoa> lista)
        {
            List<Pessoa> novaLista = new List<Pessoa>();
            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].GetIdade() < 18)
                {
                    lista.Remove(lista[i]);
                }
            }

            return novaLista;
        }

        public static void ProcurarPessoa(List<Pessoa> lista, string nome)
        {
            System.Console.WriteLine($"Há alguém com nome {nome} na lista?");
            System.Console.WriteLine(lista.Exists(pessoa => pessoa.GetNome() == nome));
        }

        public override string ToString()
        {
            string retorno = $"Nome: {this.Nome}, idade: {this.Idade}.";
            return retorno;
        }
    }
}