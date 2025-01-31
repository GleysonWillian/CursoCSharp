// Os comandos são executados ao menos 1x.
// Primeiro executa os camandos e depois testa (diferente do while).
using System;
class Aula21
{
    static void Main()
    {
        string senha = "123";
        string senhauser;
        int tentativas = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser = Console.ReadLine();
            tentativas++;

        } while (senha != senhauser);

        Console.WriteLine("Senha correta. Tentativas: {0}.", tentativas);
    }
}