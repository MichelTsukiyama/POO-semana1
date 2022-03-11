using System;
using System.Collections.Generic;

namespace exercicio3.src
{
    public class Mago : Personagem
    {
        private List<string> Magia{ get; set; }

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
        : base(nome, vida, mana, xp, inteligencia, forca, level)
        {   
            Magia = new List<string>();
        }

        public string getMagia()
        {
            string retorno = $"Magias de {Nome}:" + Environment.NewLine;
            foreach (var item in this.Magia)
            {
                retorno += item + Environment.NewLine;
            }
            return retorno;
        }

        public void setMagia(string magia)
        {
            this.Magia.Add(magia);
        }

        public override string lvlUp()
        {
            this.Vida += 40;
            this.Mana += 100;
            this.Inteligencia += 5;
            this.Forca += 1;
            this.Level += 1;

            return ToString();
        }

        public string attack()
        {
            Random random = new Random();
            int dano = this.Inteligencia * this.Level + random.Next(0, 300);
            return $"O mago {this.Nome} usou uma magia e causou {dano} de dano.\n";
        }

        public string aprenderMagia(string magia)
        {
            this.Magia.Add(magia);
            return $"Magia {magia} aprendida\n";
        }
    }
}