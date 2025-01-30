using System;

class Aula10
{

    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };

    static void Main()
    {
        // Com enum é um recurso que permite criar um tipo próprio com valores pré-definidos.

        //cast: 
        //DiasSemana ds = (DiasSemana)5;

        //descobrindo o índice do dia através de conversão:
        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);

    }
}