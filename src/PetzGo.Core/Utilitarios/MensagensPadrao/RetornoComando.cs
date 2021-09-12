namespace PetzGo.Core.Utilitarios.MensagensPadrao
{
    public static class RetornoComando
    {
        public static string MensagemComandoInvalido<T>(T comando) => $"{comando.GetType()} inválido.";

        public static string MensagemComandoCampoInexistente(string nomeCampo) => $"{nomeCampo} inexistente.";

        public static string MensagemComandoCampoExistente(string nomeCampo) => $"{nomeCampo} já existe.";
    }
}
