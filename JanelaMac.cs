namespace Bridge;

public class JanelaMac : IJanelaImplementada
{
    public void DesenharJanela(string titulo)
    {
        Console.WriteLine($"{titulo} - Janela MAC");
    }

    public void DesenharBotao(string titulo)
    {
        Console.WriteLine($"{titulo} - Botao MAC");
    }
}