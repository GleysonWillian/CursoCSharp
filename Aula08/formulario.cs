using System;

class Aula08{

    static void Main(){
        string nome;
        int idade;
        string sexo;
        string rua;

        Console.WriteLine("\n{10}Formulário de cadastrado:{10}\n");
        Console.WriteLine("Digite o seu nome: ");
        nome = string(Console.ReadLine);
        Console.WriteLine("Digite a sua idade: ");
        idade = int.Parse((Console.ReadLine));
        Console.WriteLine("Sexo (masc/fem): ");
        nome = string(Console.ReadLine);
        Console.WriteLine("Qual o nome da rua onde");
        nome = string(Console.ReadLine);
        Console.WriteLine("Fim do programa!");
    }
}