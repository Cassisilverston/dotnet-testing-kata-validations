using FluentAssertions;
using Validations;

namespace Validations.Tests;

public class ValidacoesStringTests
{
    [Fact]
    public void RetornarQuantidadeCaracteres_DeveRetornarZero_QuandoTextoForNull()
    {
        ValidacoesString.RetornarQuantidadeCaracteres(null).Should().Be(0);
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    [InlineData("cassiano", 8)]
    public void RetornarQuantidadeCaracteres_DeveRetornarQuantidadeCorreta(string texto, int esperado)
    {
        ValidacoesString.RetornarQuantidadeCaracteres(texto).Should().Be(esperado);
    }

    [Theory]
    [InlineData("hello", "h", true)]
    [InlineData("hello", "z", false)]
    public void ContemCaractere_DeveRetornarCorreto(string texto, string caractere, bool esperado)
    {
        ValidacoesString.ContemCaractere(texto, caractere).Should().Be(esperado);
    }

    [Fact]
    public void ContemCaractere_DeveRetornarFalse_QuandoTextoForNullOuVazio()
    {
        ValidacoesString.ContemCaractere(null, "a").Should().BeFalse();
        ValidacoesString.ContemCaractere("", "a").Should().BeFalse();
    }

    [Theory]
    [InlineData("csharp", "arp", true)]
    [InlineData("csharp", "sharp", true)]
    [InlineData("csharp", "har", false)]
    public void TextoTerminaCom_DeveRetornarCorreto(string texto, string sufixo, bool esperado)
    {
        ValidacoesString.TextoTerminaCom(texto, sufixo).Should().Be(esperado);
    }

    [Theory]
    [InlineData("dotnet", "do", true)]
    [InlineData("dotnet", "net", false)]
    public void TextoComecaCom_DeveRetornarCorreto(string texto, string prefixo, bool esperado)
    {
        ValidacoesString.TextoComecaCom(texto, prefixo).Should().Be(esperado);
    }
}
