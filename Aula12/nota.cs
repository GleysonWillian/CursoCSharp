using System;

class Aula12{

    static void Main(){

        int nota = 0;
        string resutado = "Reprovado";

        Console.WriteLine("Digite o valor da nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 60){
            resutado = "Aprovado";
        }
        Console.WriteLine("Resultado: {0}!", resutado);
    }
}