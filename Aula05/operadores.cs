using System;

class Aula05
{

    static void Main()
    {

        // categorias:

        // atribuição (= e +):
        //int  res = (10 + 5)*5;

        //relacionais (true or false):
        //bool res = 10!=5;
        //operadores relacionais: >, <, <=, >=, !=.

        //incremento e decremento:
        //int num = 10;

        //num = num + 1; // é igual a num+=1; ou num++;
        //exceto num = num + 2 ou num += 2; (o valor 2 é exemplo)
        //pode ser usad para soma, sub, div e mult.

        //Console.WriteLine(num);  

        //op. lógicos: and e or:
        // & = AND -> retorna true se todas forem true.
        // | = OR -> retorna false se todas forem falsas.
        bool res = (5 > 3) & (10 > 5);

        Console.WriteLine(res);

    }
}