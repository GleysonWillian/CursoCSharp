using System;
using System.Data;
class metodos_3
{
    static void Main()
    {
        int v1, v2;
        Console.WriteLine("Digite o valor de um número: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de outro número: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1, v2);
    }

    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é igual a {2}", n1, n2, res);
    }

}