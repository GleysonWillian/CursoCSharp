using System;

class Aula08
{

    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;

        Console.WriteLine("A soma de {0} e {1} é igual a {2}.", v1, v2, soma);
        Console.WriteriteLine("Fim do programa!");
    }
}