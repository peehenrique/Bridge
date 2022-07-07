namespace Bridge;

public class JanelaLinux : IJanelaImplementada
{
    public void DesenharJanela(string titulo)
    {
        Console.WriteLine($"{titulo} - Janela Linux");
    }

    public void DesenharBotao(string titulo)
    {
        Console.WriteLine($"{titulo} - Botao Linux");
    }
}