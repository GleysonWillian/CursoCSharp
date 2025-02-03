// -> Métodos: conjunto de instruções que pode ser invocado a qualquer momento dentro do programa
// -> static é um método
// -> Invocando um método com retorno void (sem retorno de dados e sem entrada de parâmetros)


using System;
class Aula24
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            ola();
        }
    }

    static void ola()
    {
        Console.WriteLine("Olá. Sou estudante de programação!");
    }

}