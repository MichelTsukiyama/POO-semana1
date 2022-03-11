namespace exercicio7.src
{
    public class Funcionario
    {
        protected string Nome { get; set; }
        protected int Idade { get; set; }
        protected double Salario { get; set; }

        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }
        
        public Funcionario()
        {
            
        }

        public virtual string Bonificacao()
        {
            return $"Bonificação de {this.Salario}";
        }
    }
}