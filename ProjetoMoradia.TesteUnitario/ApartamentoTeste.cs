using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class ApartamentoTeste
{
    [Fact]
    public void ApartamentoNaoPodeTerMaisDeTresBanheiros()
    {
        //Arrange
        var quantidaDeBanheirosInvalida = 4;
        var moradia = new Apartamento("teste", 1234567, 100, quantidaDeBanheirosInvalida, 1, 10, 1000);

        //Act
        var quantidaDeBanheirosAtual = moradia.GetQuantidadeDeBanheiros();

        //Assert
        Assert.Equal(0, quantidaDeBanheirosAtual);
    }

    [Fact]
    public void ApartamentoNaoPodeTerMaisDeSessentaMetros()
    {
        //Arrange
        var quantidadeDeMetrosInvalida = 61;
        var moradia = new Apartamento("teste", 1234567, quantidadeDeMetrosInvalida, 1, 1, 1, 100);

        //Act
        var quantidadeDeMetrosAtual = moradia.GetTamanhoEmMetros();

        //Assert
        Assert.Equal(0, quantidadeDeMetrosAtual);
    }

    [Fact]
    public void ApartamentoPodeSerNoMaxeecimoAndar()
    {
        //Arrange
        var andarInvalido = 11;
        var moradia = new Apartamento("teste", 1234567, 50, 1, 1, andarInvalido, 100);

        //Act
        var andarAtual = moradia.GetAndar();

        //Assert
        Assert.Equal(0, andarAtual);
    }
}