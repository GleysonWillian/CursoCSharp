using System;

class array_e_for
{

    static void Main()
    {
        int[] num = new int[10];
        int i;

        for (i = 0; i < 10; i++)
        {
            num[i] = 0;
            Console.WriteLine("Valor de num na posição {0}: {1}", i, num[i]);
        }

        Console.WriteLine("\nFim do programa!");

    }
}