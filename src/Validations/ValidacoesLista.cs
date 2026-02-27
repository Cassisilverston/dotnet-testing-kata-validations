namespace Validations;

public static class ValidacoesLista
{
    public static int RetornarQuantidadeElementos<T>(IEnumerable<T>? lista)
    {
        return lista?.Count() ?? 0;
    }

    public static bool ListaContemDeterminadoNumero(IEnumerable<int>? lista, int numero)
    {
        return lista != null && lista.Contains(numero);
    }

    public static IEnumerable<int> RetornarMaiorNumeroLista(IEnumerable<int>? lista)
    {
        if (lista == null) return Array.Empty<int>();

        var arr = lista as int[] ?? lista.ToArray();
        if(arr.Length == 0) return Array.Empty<int>();

        var max = arr.Max();
        return arr.Where(x => x == max);
    }

    public static IEnumerable<int> RetornarMenorNumeroLista(IEnumerable<int>? lista)
    {
        if (lista == null) return Array.Empty<int>();

        var arr = lista as int[] ?? lista.ToArray();
        if (arr.Length == 0) return Array.Empty<int>();

        var min = arr.Min();
        return arr.Where(x => x == min);
    }
}