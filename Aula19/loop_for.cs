//Estrutura:
// for(a){
//}
//a = inicializador ou contador (pode inicializar dentro ou fora do loop);
//b = expressão lógica;
//c = incremento/decremento;

using System;

class Aula19
{

    static void Main()
    {
        int num;

        for (num = 0; num < 10; num++)
        {
            Console.WriteLine("Valor de num: {0}", num);
        }

        Console.WriteLine("\nFim do programa!");

    }
}