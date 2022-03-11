namespace exercicio7.src
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) 
        : base (nome, idade, salario) 
        {
           
        }
        public override string Bonificacao()
        {
            const double bonus = 10000.00;
            string retorno = "";
            retorno += $"O gerente {base.Nome} tem bonificação de R${(base.Salario + bonus).ToString("0.00")}.";
            return retorno;
        }
    }
}