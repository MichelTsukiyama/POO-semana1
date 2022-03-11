namespace exercicio2.src
{
    public class Livro : Produto
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro()
        {
            
        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            base.nome = nome;
            base.preco = preco;
            base.qtd = qtd;
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

         public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
         public string GetTema()
        {
            return this.tema;
        }
        public void SetTema(string tema)
        {
            this.tema = tema;
        }

         public int GetQtdPag()
        {
            return this.qtdPag;
        }
        public void SetQtdPag(int qtdPag)
        {
            this.qtdPag = qtdPag;
        }

        public double calculaImposto()
        {
            double imposto;
            if(this.tema == "educativo")
            {
                System.Console.WriteLine($"Livro educativo não tem imposto: {base.nome}.");
                return 0;
            }
            else
            {
                imposto = base.preco * 0.10;
                System.Console.WriteLine($"R$ {imposto.ToString("0.00").Replace(",", ".")} de impostos sobre o livro {base.nome}.");
                return  imposto;
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Titulo: " + base.nome + ", ";
            retorno += "preco: " + base.preco.ToString("0.00").Replace(",",".") + ", ";
            retorno += "quantidade: " + base.qtd + " em estoque.";
            return retorno;
        }
    }
}