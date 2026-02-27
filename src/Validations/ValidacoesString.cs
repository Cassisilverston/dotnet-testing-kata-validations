namespace Validations;

public static class ValidacoesString
{
    public static int RetornarQuantidadeCaracteres(string? texto)
    {
        return texto?.Length ?? 0;
    }

    public static bool ContemCaractere(string? texto, string caractere)
    {
        return !string.IsNullOrEmpty(texto) && texto.Contains(caractere);
    }

    public static bool TextoTerminaCom(string? texto, string sufixo)
    {
        return !string.IsNullOrEmpty(texto) && texto.EndsWith(sufixo, StringComparison.Ordinal);
    }

    public static bool TextoComecaCom(string? texto, string prefixo)
    {
        return !string.IsNullOrEmpty(texto) && texto.StartsWith(prefixo);
    }


}

