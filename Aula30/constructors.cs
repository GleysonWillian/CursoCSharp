﻿using System;
using Microsoft.VisualBasic;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo =v;
        nome = n;
    }
    public void info(){
        Console.WriteLine("Nome jogador......: {0}", nome);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("Estado do jogador.: {0}\n", vivo);
    }

}
class Aula30
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Gabriel");
        Jogador j3 = new Jogador("Julio", 100);
        Jogador j4 = new Jogador("Gordon", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}