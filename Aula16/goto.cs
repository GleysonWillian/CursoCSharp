using System;
class Aula15{
    static void Main(){
        
        int tempo = 0;
        char escolha;

        // sempre que quiser apontar para um ponto específico, crie um label:
        inicio:

        Console.Clear();

        Console.WriteLine("Madri/ESP - Lisboa/PT");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 330;
                break;
            case 'o':
            case 'O':
                tempo = 580;
                break;
            default:
                tempo = -1;
                break;
        }

        if(tempo < 0){
            Console.WriteLine("Transporte indisponível!");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos.", tempo);
        }

        Console.Write("\nCalcular outro transporte? [s/n] ");
        escolha = char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("FIm do programa!");
        }
    }
}