using FluentAssertions;
using Validations;

namespace Validations.Tests;

public class ValidacoesListaTests
{
    [Fact]
    public void RetornarQuantidadeElementos_DeveRetornarZero_QuandoListaForNull()
    {
        ValidacoesLista.RetornarQuantidadeElementos<int>(null).Should().Be(0);
    }

    [Fact]
    public void RetornarQuantidadeElementos_DeveRetornarQuantidadeCorreta()
    {
        var lista = new[] { 1, 2, 3 };
        ValidacoesLista.RetornarQuantidadeElementos(lista).Should().Be(3);
    }

    [Fact]
    public void ListaContemDeterminadoNumero_DeveRetornarTrue_QuandoContem()
    {
        var lista = new[] { 5, 7, 9 };
        ValidacoesLista.ListaContemDeterminadoNumero(lista, 7).Should().BeTrue();
    }

    [Fact]
    public void ListaContemDeterminadoNumero_DeveRetornarFalse_QuandoNaoContemOuNull()
    {
        var lista = new[] { 5, 7, 9 };
        ValidacoesLista.ListaContemDeterminadoNumero(lista, 10).Should().BeFalse();
        ValidacoesLista.ListaContemDeterminadoNumero(null, 10).Should().BeFalse();
    }

    [Fact]
    public void RetornarMaiorNumeroLista_DeveRetornarTodosOsMaiores_QuandoRepetidos()
    {
        var lista = new[] { 1, 5, 2, 5, 3 };

        var resultado = ValidacoesLista.RetornarMaiorNumeroLista(lista);

        resultado.Should().BeEquivalentTo(new[] { 5, 5 });
    }

    [Fact]
    public void RetornarMenorNumeroLista_DeveRetornarTodosOsMenores_QuandoRepetidos()
    {
        var lista = new[] { 1, 5, 1, 2 };

        var resultado = ValidacoesLista.RetornarMenorNumeroLista(lista);

        resultado.Should().BeEquivalentTo(new[] { 1, 1 });
    }

    [Fact]
    public void RetornarMaiorOuMenor_DeveRetornarVazio_QuandoListaForNullOuVazia()
    {
        ValidacoesLista.RetornarMaiorNumeroLista(null).Should().BeEmpty();
        ValidacoesLista.RetornarMaiorNumeroLista(Array.Empty<int>()).Should().BeEmpty();

        ValidacoesLista.RetornarMenorNumeroLista(null).Should().BeEmpty();
        ValidacoesLista.RetornarMenorNumeroLista(Array.Empty<int>()).Should().BeEmpty();
    }
}