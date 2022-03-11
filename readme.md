# Exercícios de POO

Exercícios realizados na primeira semana dos Starters #3, turma 01/2022.

**Obs. Exercícios 5 e 6 estão na Classe Program.cs do exercício 4.**

---------

## Versão utilizada

.Net 5.0

--------

## Principais dúvidas durante os exercícios

- É necessário criar métodos GetAtributo()/SetAtributo(), ou usa-se atributo{get; set;}?. Em quais cenários usar um, e/ou outro, ou se há algum padrão em projetos.

- Tinha dúvidas com relação a protected e private, e como acessar os atributos protected em uma classe mãe. Pelo que entendi protected pode ser acessado dentro do mesmo assembly, e private somente dentro da mesma classe. Para acessar um atributo protected pode se usar o "base" ou base.Get()/Set().

- No exercício 3 fiz o seguinte construtor:

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.Habilidade = new List<string>();
        }

Ele instancia um List<> para armazenar as habilidades, não sabia que era possível fazer assim.

- No Exercício 5, tentei usar o foreach para remover itens de uma lista. Encontrei uma solução usando 2 laços foreach, mas gostaria de implementar usando apenas 1. O problema estava em adquirir o índice do item na lista.

- Exercício 7, não tinha entendido bem o que era a classe principal para instanciar as objetos... Na verdade era só o Program.cs com o "main".

-------

## Desenvolvimento pessoal

- Elaborar soluções simples que atenda o que foi pedido, posteriormente com mais tempo ir refatorando e tentando aprimorar a solução.



