namespace Cod3rsGrowth.Servico.ExtensaoDasStrings
{
    public static class ExtensaoStrings
    {
        public static bool ContemValor(this string? valor)
        {
            return !string.IsNullOrEmpty(valor);
        }
    }
}
