namespace Bridge;

public class JanelaWindows : IJanelaImplementada
{
    public void DesenharJanela(string titulo)
    {
        Console.WriteLine($"{titulo} - Janela Windows");
    }

    public void DesenharBotao(string titulo)
    {
        Console.WriteLine($"{titulo} - Botao Windows");
    }
}