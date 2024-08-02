public class Gerente : Funcionario
{
    public decimal Bonus { get; set; }

    public Gerente(string nome, decimal salario, decimal bonus) 
        : base(nome, salario)
    {
        Bonus = bonus;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($"Bônus: {Bonus:C}");
    }
}