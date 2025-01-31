// usa-se quando não tem certeza da quantidade.
// a  inicialização deve ser fora no comando.
using System;

class while_com_array
{

    static void Main()
    {
        int[] num = new int[10];

        int i = 0;
        while (i < num.Length)
        {
            num[i]=0;
            Console.WriteLine(num[i]);
            i++;
        }

        Console.WriteLine("Fim do loop!");
    }
}