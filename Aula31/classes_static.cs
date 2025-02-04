using System;
using Microsoft.VisualBasic;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    static public void info(){
        Console.WriteLine("Nome jogador......: {0}", nome);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("Estado do jogador.: {0}\n", vivo);
    }

}

class Inimigo{
    public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
    }
}
class Aula31
{
    static void Main()
    {
        Jogador.iniciar("Bruno");
        Jogador.info();

        
    }
}