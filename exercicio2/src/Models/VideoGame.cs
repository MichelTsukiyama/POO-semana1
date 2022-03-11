using exercicio2.Interface;

namespace exercicio2.src
{
    public class VideoGame : Produto , IImposto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public VideoGame()
        {
            
        }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            base.nome = nome;
            base.preco = preco;
            base.qtd = qtd;
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public bool GetIsUsado()
        {
            return this.isUsado;
        }
        public void SetIsUsado(bool isUsado)
        {
            this.isUsado = isUsado;
        }

        public double calculaImposto()
        {
            double imposto;
            if(this.isUsado == true)
            {
                imposto = base.preco *  0.25;
                System.Console.WriteLine($"Imposto {base.nome} {this.modelo} usado, R$ {imposto.ToString("0.00").Replace(",", ".")}.");
                return imposto;
                
            }
            else
            {
                imposto = base.preco * 0.45;
                System.Console.WriteLine($"Imposto {base.nome} {this.modelo} R$ {imposto.ToString("0.00").Replace(",", ".")}.");
                return  imposto;
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Video-game: " + this.modelo + ", ";
            retorno += "preco: " + base.preco.ToString("0.00").Replace(",",".") + ", ";
            retorno += "quantidade: " + base.qtd + " em estoque.";
            return retorno;
        }
    }
}