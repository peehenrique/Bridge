namespace Bridge;

public abstract class JanelaAbstrata
{
    protected IJanelaImplementada _janelaImplementada;

    public JanelaAbstrata(IJanelaImplementada janelaImplementada)
    {
        _janelaImplementada = janelaImplementada;
    }

    public void DesenharJanela(string titulo)
    {
        _janelaImplementada.DesenharJanela(titulo);
    }
    
    public void DesenharBotao(string titulo)
    {
        _janelaImplementada.DesenharBotao(titulo);
    }

    public abstract void Desenhar();
}