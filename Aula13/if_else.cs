using System;

class Aula13
{

    static void Main()
    {

        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        string resultado;

        Console.WriteLine("Digite o valor da primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        if (res >= 60)
        {
            resultado = "Aprovado";
        }
        else
        {
            resultado = "Reprovado";
        }
        Console.WriteLine("\nNota: {0}.\nResultado: {1}!\n", res, resultado);
    }
}