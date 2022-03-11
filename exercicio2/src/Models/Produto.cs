namespace exercicio2.src
{
    public abstract class Produto
    {
        protected string nome;
        protected double preco;
        protected int qtd;

        public Produto()
        {
            
        }
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public double GetPreco()
        {
            return this.preco;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public int GetQtd()
        {
            return this.qtd;
        }
        public void SetQtd(int qtd)
        {
            this.qtd = qtd;
        }
    }
}