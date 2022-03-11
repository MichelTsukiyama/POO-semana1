using System;
using exercicio3.src;


namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem("Teste", 100, 100, 0, 5, 5, 5);
            Mago mago = new Mago("Mago1", 100, 100, 0, 5, 5, 5); 
            Guerreiro guerreiro = new Guerreiro("Guerreiro1", 100, 100, 0, 5, 5, 5);

            System.Console.WriteLine(personagem);
            System.Console.WriteLine(mago.lvlUp());
            System.Console.WriteLine(mago.attack());
            System.Console.WriteLine(mago.aprenderMagia("Relâmpago"));
            System.Console.WriteLine(mago.getMagia());
            System.Console.WriteLine(guerreiro.lvlUp());
            System.Console.WriteLine(guerreiro.attack());
            System.Console.WriteLine(guerreiro.aprenderHabilidade("Brandir"));
            System.Console.WriteLine(guerreiro.aprenderHabilidade("Avançar"));
            System.Console.WriteLine(guerreiro.getHabilidade()); 

            string total = Personagem.getTotalPersonagens();
            System.Console.WriteLine(total);

        }
    }
}
