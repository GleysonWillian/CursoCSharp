﻿using System;
class Jogador{
    public int energia;
    public string nome;
    public Jogador(string nome){
        this.nome = nome;
        energia = 100;
    }
}
class Aula33{
    static void Main(){
        Jogador j1 = new Jogador("Marcelo");

        Console.WriteLine("Nome....: {0}", j1.nome);
        Console.WriteLine("Energia.: {0}", j1.energia);

    }
}