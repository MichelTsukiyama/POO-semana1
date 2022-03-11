using System;

namespace exercicio3.src
{
    public class Personagem
    {
        protected string Nome { get; set; }
        protected int Vida { get; set; }
        protected int Mana { get; set; }
        protected float Xp { get; set; }
        protected int Inteligencia { get; set; }
        protected int Forca { get; set; }
        protected int Level { get; set; }
        protected static int totalPersonagens = 0;

        public Personagem(string nome, int vida, int mana, float xp,int inteligencia, int forca, int level)
        {
            Personagem.totalPersonagens++;
            this.Nome = nome;
            this.Vida = vida;
            this.Mana = mana;
            this.Xp = xp;
            this.Inteligencia = inteligencia;
            this.Forca = forca;
            this.Level = level;
        }

        public Personagem()
        {
            Personagem.totalPersonagens++;
        }

        public Personagem(string nome)
        {
            Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }
        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public int getVida()
        {
            return this.Vida;
        }
        public void setVida(int vida)
        {
            this.Vida = vida;
        }
        public int getMana()
        {
            return this.Mana;
        }
        public void setMana(int mana)
        {
            this.Mana = mana;
        }
        public float getXp()
        {
            return this.Xp;
        }
        public void setXp(float xp)
        {
            this.Xp = xp;
        }
        public int getInteligencia()
        {
            return this.Inteligencia;
        }

        public void setInteligencia(int inteligencia)
        {
            this.Inteligencia = inteligencia;
        }
        public int getForca()
        {
            return this.Forca;
        }

        public void setForca(int forca)
        {
            this.Forca = forca;
        }

        public int getLevel()
        {
            return this.Level;
        }

        public void setLevel(int level)
        {
            this.Level = level;
        }

        public static string getTotalPersonagens()
        {   
            return $"Total de personagens: {totalPersonagens}";
        }
        public virtual string lvlUp()
        {
            return "texto";
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Personagem: {Nome}" + Environment.NewLine;
            retorno += $"Vida: {Vida}" + Environment.NewLine;
            retorno += $"Mana: {Mana}" + Environment.NewLine;
            retorno += $"Xp: {Xp}" + Environment.NewLine;
            retorno += $"Inteligencia: {Inteligencia}" + Environment.NewLine;
            retorno += $"Forca: {Forca}" + Environment.NewLine;
            retorno += $"Level: {Level}" + Environment.NewLine;
            return retorno;
        }
    }
}