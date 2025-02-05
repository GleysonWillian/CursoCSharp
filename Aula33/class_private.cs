using System;
class Jogador2
{
    private int energia;
    private string nome;
    public Jogador2(string nome)
    {
        this.nome = nome;
        energia = 100;
    }
    public int getEnergia()
    {
        return energia;
    }
    public string getNome()
    {
        return nome;
    }
    public void setEnergia(int e)
    {
        if (e < 0)
        {
            if (energia + e < 0)
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        else if (e > 0)
        {
            if (energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
    }
}
class class_private
{
    static void Main()
    {

        Jogador2 j2 = new Jogador2("Pedro");

        j2.setEnergia(-150);

        Console.WriteLine("Nome....: {0}", j2.getNome());
        Console.WriteLine("Energia.: {0}", j2.getEnergia());
    }
}