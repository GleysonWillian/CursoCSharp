using System;
using System.Diagnostics.Contracts;
class Aula25
{
    static void Main()
    {
        int num = 10;
        // passagem por referência
        dobrar1(ref num); 
        // passagem por valor:
        //dobrar2(num);
        //Console.WriteLine(num);
    }

    //Passagem por referência:
    static void dobrar1(ref int valor)
    {
        valor *= 2;
    }
    //Passagem por valor:
    //static void dobrar2( int valor)
    //{
        //valor *= 2;
}