namespace Bridge;

public class JanelaAviso : JanelaAbstrata
{
    public JanelaAviso(IJanelaImplementada janelaImplementada) : base(janelaImplementada)
    {
    }

    public override void Desenhar()
    {
        DesenharJanela("Janela de Aviso");
        DesenharBotao("Ok");
    }
}