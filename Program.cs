using Bridge;

JanelaAbstrata janela = new JanelaDialogo(new JanelaWindows());
janela.Desenhar();

janela = new JanelaAviso(new JanelaLinux());
janela.Desenhar();

janela = new JanelaDialogo(new JanelaMac());
janela.Desenhar();
