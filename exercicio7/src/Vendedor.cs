namespace exercicio7.src
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) 
        : base (nome, idade, salario) 
        {
           
        }
        public override string Bonificacao()
        {
            const double bonus = 3000.00;
            string retorno = "";
            retorno += $"O vendedor {base.Nome} tem bonificação de R${(base.Salario + bonus).ToString("0.00")}.";
            return retorno;
        }
    }
}