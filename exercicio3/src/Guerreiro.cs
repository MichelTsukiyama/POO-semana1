using System;
using System.Collections.Generic;

namespace exercicio3.src
{
    public class Guerreiro : Personagem
    {
        private List<string> Habilidade { get; set; }

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.Habilidade = new List<string>();
        }

        public string getHabilidade()
        {
            string retorno = $"\nHabilidades de {Nome}: " + Environment.NewLine; 
            foreach (var item in this.Habilidade)
            {
                retorno += item + Environment.NewLine;
            }

            return retorno;
        }

        public void setHabilidade(string magia)
        {
            this.Habilidade.Add(magia);
        }

        public override string lvlUp()
        {
            this.Vida += 100;
            this.Mana += 40;
            this.Inteligencia += 1;
            this.Forca += 5;
            this.Level += 1;

            return ToString();
        }

        public string attack()
        {
            Random random = new Random();
            int dano = this.Inteligencia * this.Level + random.Next(0, 300);
            return $"O Guerreiro {this.Nome} usou um ataque e causou {dano} de dano.\n";
        }

        public string aprenderHabilidade(string habilidade)
        {
            this.Habilidade.Add(habilidade);
            return $"Habilidade {habilidade} aprendida.\n";
        }
    }
}