//Estrutura para declaração de array (array unidimensional):
        // Define o tipo: string, char, float, int...
        // Operador []...
        // Nome...
        // Exemplo:
                // int[] num = {15, 12, 32};
                // ou
                // int[] num = new int[];
                // num[1] = 1;
                // num[2] =2;
                // ...
                // ...
                // ou
                // int[] num = new int[3]{1, 2, 3};

using System;

class Aula17{

    static void Main(){

        //declarando o array:
        int[] n = new int [5];
        // inicializando depois de declarar:
        n[0] = 20;
        n[1] = 30;
        n[2] = 40;
        n[3] = 50;
        n[4] = 60;

        // declarando o array e inicializando:
        int[] num = new int[3]{3,6,8};

        //declarando o array e atribuindo o valor sem operador:
        int[] num1 = {55, 90, 120};

        Console.WriteLine(num1[3]);

    }
}