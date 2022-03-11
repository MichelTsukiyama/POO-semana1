namespace exercicio7.src
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) 
        : base (nome, idade, salario) 
        {
           
        }
        public override string Bonificacao()
        {
            const double bonus = 5000.00;
            string retorno = "";
            retorno += $"O supervisor {base.Nome} tem bonificação de R${(base.Salario + bonus).ToString("0.00")}.";
            return retorno;
        }
    }
}