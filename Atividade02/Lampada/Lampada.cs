namespace aula02;
public class Lampada
{
    private bool ligada;

    public Lampada(bool ligada)
    {
        this.ligada = ligada;
    }

    public void Ligar()
    {
        ligada = true;
    }

    public void Desligar()
    {
        ligada = false;
    }

    public void Imprimir()
    {
        if (ligada)
            Console.WriteLine("Lâmpada ligada");
        else
            Console.WriteLine("Lâmpada desligada");
    }
}
