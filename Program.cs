using System;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func1 = new Funcionario("Ana", 3000);
        Gerente gerente1 = new Gerente("Carlos", 7000, 1500);

        func1.ExibirDetalhes();
        Console.WriteLine();

        gerente1.ExibirDetalhes();
    }
}