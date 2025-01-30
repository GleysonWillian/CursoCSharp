using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args) // argumentos de entrada
        {
            Console.WriteLine("Hello, World!");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}