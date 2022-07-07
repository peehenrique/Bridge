namespace Bridge;

public class JanelaDialogo : JanelaAbstrata
{
    public JanelaDialogo(IJanelaImplementada janelaImplementada) : base(janelaImplementada)
    {
    }

    public override void Desenhar()
    {
        DesenharJanela("Janela de Dialogo");
        DesenharBotao("Botao Sim");
        DesenharBotao("Botao Nao");
        DesenharBotao("Botao Cancelar");
    }
}